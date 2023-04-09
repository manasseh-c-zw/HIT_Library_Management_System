using HIT_Library_Manager_Lib;
using HIT_Library_Manager_Lib.Models;
using Library_Manager_UI.Components;
using Library_Manager_UI.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Library_Manager_UI
{
    public partial class cLibrary : Form
    {
        public cLibrary()
        {
            InitializeComponent();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var book = new BookCard();
            book.BookCover = Resources.userProfileDark;
            book.Title = "Beautiful";
            fpanelBooks.Controls.Add(book);
        }

        private void cLibrary_Load(object sender, EventArgs e)
        {
            var books = SQliteConnector.LoadBooks();
            LoadBooks(books);

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var addbook = new AddBook();
            addbook.ShowDialog();
        }

        private void LoadBooks(List<BookModel> books)
        {

            foreach (var book in books)
            {
                var card = new BookCard();
                card.BookCover = Image.FromFile(book.CoverImage);
                card.Title = book.Title;
                fpanelBooks.Controls.Add(card);
            }
        }

    }
}
