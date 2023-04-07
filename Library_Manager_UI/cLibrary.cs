using Library_Manager_UI.Components;
using Library_Manager_UI.Properties;
using System;
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

        }

        private void cLibrary_Load(object sender, EventArgs e)
        {

        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            var book = new BookCard();
            book.BookCover = Resources.userProfileDark;
            book.Title = "Beautiful";
            fpanelBooks.Controls.Add(book);
        }
    }
}
