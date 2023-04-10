using HIT_Library_Manager_Lib.Models;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Library_Manager_UI.Components
{
    public partial class BookCard : UserControl
    {

        private Image bookCover;
        private string title;
        public BookModel Book { get; set; }

        [Category("Custom Props")]
        public Image BookCover
        {
            get { return bookCover; }
            set { bookCover = value; pbBookCover.Image = value; }

        }

        [Category("Custom Props")]
        public string Title
        {
            get { return title; }
            set
            {
                title = value;
                lblTitle.Text = value;

            }

        }

        [Category("Custom Props")]
        public Color TitleColor
        {
            get { return lblTitle.ForeColor; }
            set
            {
                lblTitle.ForeColor = value;
            }

        }


        public BookCard()
        {
            InitializeComponent();
        }


        public void Activate()
        {
            this.BackColor = Color.FromArgb(55, 64, 179);
            this.ForeColor = Color.FromArgb(217, 234, 245);
        }

        public void Deactivate()
        {
            this.BackColor = Color.FromArgb(217, 234, 245);
            this.ForeColor = Color.Black;
        }


        //custom event
        public event EventHandler BookCoverClick;

        private void pbBookCover_Click(object sender, EventArgs e)
        {
            // Raise the BookCoverClick event
            BookCoverClick?.Invoke(this, e);
        }
        private void pbBookCover_MouseLeave(object sender, EventArgs e)
        {
            if (this != cLibrary.activeCard)
            {
                Deactivate();
            }
        }

        private void pbBookCover_MouseDown(object sender, MouseEventArgs e)
        {
            pbBookCover.Focus();
        }

    }
}
