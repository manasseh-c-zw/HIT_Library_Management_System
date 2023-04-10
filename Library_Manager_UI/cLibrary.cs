using HIT_Library_Manager_Lib;
using HIT_Library_Manager_Lib.Models;
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
        public static BookCard activeCard;

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
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var addbook = new AddBook();
            addbook.ShowDialog();
        }

    }
}
