using HIT_Library_Manager_Lib;
using HIT_Library_Manager_Lib.Models;
using HIT_Library_Manager_Lib.Validators;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Library_Manager_UI
{
    public partial class AddBook : Form
    {
        byte[] imageData = null;
        string fileExtention = null;
        public AddBook()
        {
            InitializeComponent();
        }

        private void lblBookCount_Click(object sender, System.EventArgs e)
        {

        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }
        private void linkCoverImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                imageData = File.ReadAllBytes(openFileDialog1.FileName);
                fileExtention = Path.GetExtension(openFileDialog1.FileName);

                pbBookCover.Image = Image.FromFile(openFileDialog1.FileName);
                txtPreTitle.Text = txtTitle.Text;
            }


        }
        private void btnAdd_Click(object sender, System.EventArgs e)
        {
            var book = new BookModel()
            {
                Title = txtTitle.Text,
                Author = txtAuthor.Text,
                Publisher = txtPublisher.Text,
                PublicationYear = txtYear.Text,
                Genre = txtGenre.Text,
                ISBN = txtISBN.Text,
                BookCount = (int)numBookCount.Value

            };

            //validating a the book
            BookValidator validator = new BookValidator();
            var results = validator.Validate(book);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    dialogError.Show(failure.ErrorMessage);

                }
                ResetControls();
                return;
            }


            try
            {
                SQliteConnector.AddBook(book, imageData, fileExtention);
                dialogSuccess.Show("Book Added!");
            }
            catch (Exception ex)
            {

                dialogError.Show(ex.Message);
            }


        }

        public void ResetControls()
        {
            txtTitle.Clear();
            txtAuthor.Clear();
            txtPublisher.Clear();
            txtYear.Clear();
            txtGenre.Clear();
            txtISBN.Clear();
            numBookCount.Value = 1;
            pbBookCover.Image = null;
            txtPreTitle.ResetText();
        }

        private void AddBook_Activated(object sender, EventArgs e)
        {
            designAddBook.HasFormShadow = true;
        }
    }
}
