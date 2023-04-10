using HIT_Library_Manager_Lib;
using HIT_Library_Manager_Lib.Models;
using HIT_Library_Manager_Lib.Validators;
using Library_Manager_UI.Components;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Library_Manager_UI
{
    public partial class cLibrary : Form
    {
        List<BookModel> books = SQliteConnector.LoadBooks();
        private BookCard activeCard;
        private BookModel editingBook;
        public cLibrary()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (txtSearch.Text.Length == 0)
            {
                LoadBooks(books);
                return;
            }

            switch (cmbFilter.SelectedIndex)
            {
                case 0:
                    var booksWithTitle = books.Where(b => b.Title.ToLower() == txtSearch.Text.Trim().ToLower()).ToList();
                    LoadBooks(booksWithTitle);
                    break;
                case 1:
                    var booksWithAuthor = books.Where(b => b.Author.ToLower() == txtSearch.Text.Trim().ToLower()).ToList();
                    LoadBooks(booksWithAuthor);
                    break;
                case 2:
                    var booksWithPublisher = books.Where(b => b.Publisher.ToLower() == txtSearch.Text.Trim().ToLower()).ToList();
                    LoadBooks(booksWithPublisher);
                    break;
                case 4:
                    var booksWithGenre = books.Where(b => b.Title.ToLower() == txtSearch.Text.Trim().ToLower()).ToList();
                    LoadBooks(booksWithGenre);
                    break;
                default:
                    LoadBooks(books);
                    break;
            }
        }

        private void cLibrary_Load(object sender, EventArgs e)
        {

            LoadBooks(books);

        }


        private void LoadBooks(List<BookModel> books)
        {
            fpanelBooks.Controls.Clear();
            foreach (var book in books)
            {
                BookCard card = new BookCard();
                card.Book = book;
                card.BookCover = Image.FromFile(book.CoverImage);
                card.Title = book.Title;
                // Subscribe to the BookCoverClick event
                card.BookCoverClick += Card_BookCoverClick;

                fpanelBooks.Controls.Add(card);

            }
        }


        private void Card_BookCoverClick(object sender, EventArgs e)
        {
            BookCard clickedCard = (BookCard)sender;


            // Deactivate the current card, if there is one
            if (activeCard != null)
            {
                activeCard.Deactivate();
            }

            // Activate the clicked card

            clickedCard.Activate();
            activeCard = clickedCard;

            // Enable the controls in the group box and set their values based on the selected book
            if (activeCard != null)
            {
                grpEditBook.Enabled = true;
                LoadBookDetails(clickedCard.Book);
            }
            else
            {
                // Disable the controls in the group box
                grpEditBook.Enabled = false;
            }
        }

        private void LoadBookDetails(BookModel book)
        {
            editingBook = new BookModel(book);
            if (book != null)
            {
                txtTitle.Text = editingBook.Title;
                txtAuthor.Text = editingBook.Author;
                txtGenre.Text = editingBook.Genre;
                txtPublisher.Text = editingBook.Publisher;
                txtYear.Text = editingBook.PublicationYear.ToString();
                pbBookCover.Image = Image.FromFile(editingBook.CoverImage);

                grpEditBook.Enabled = true; // Enable the group box since a book is selected
            }
            else
            {
                // Clear the details and disable the group box
                ResetControls();

                grpEditBook.Enabled = false;
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var addbook = new AddBook();
            addbook.ShowDialog();
        }

        private void grpAddBook_Leave(object sender, EventArgs e)
        {
            grpEditBook.Enabled = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Assign the modified book properties to the active book object


            editingBook.Title = txtTitle.Text;
            editingBook.Author = txtAuthor.Text;
            editingBook.Publisher = txtPublisher.Text;
            editingBook.PublicationYear = txtYear.Text;
            editingBook.Genre = txtGenre.Text;
            editingBook.BookCount = (int)numBookCount.Value;

            var modifiedBook = new BookModel(editingBook);

            if (editingBook.Equals(modifiedBook))
            {
                dialogError.Show("No Meta Data has been modified!");
                return;
            }


            BookValidator validator = new BookValidator();
            var results = validator.Validate(editingBook);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    dialogError.Show(failure.ErrorMessage);

                }
                ResetControls();
                LoadBooks(books);
                return;
            }

            //A dialog to confirm changes to the selected book item

            var dialogResult = dialogAsk.Show("Do you want to save your changes?");
            if (dialogResult == DialogResult.Yes)
            {

                try
                {
                    SQliteConnector.UpdateBook(editingBook);
                    activeCard.Book = modifiedBook;
                    dialogSuccess.Show("Changes Saved!");
                    ResetControls();

                }
                catch (Exception ex)
                {

                    dialogError.Show(ex.Message);
                }
            }
            else if (dialogResult == DialogResult.No)
            {
                editingBook = null;
                ResetControls();
            }

            editingBook = null;

        }

        private void ResetControls()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtGenre.Clear();
            txtPublisher.Clear();
            txtYear.Clear();
            pbBookCover.Image = null;
        }
    }
}
