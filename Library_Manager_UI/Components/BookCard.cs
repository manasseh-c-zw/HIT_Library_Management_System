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
            set { title = value; lblTitle.Text = value; }

        }

        public BookCard()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

        }




        private void pbBookCover_MouseHover(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(53, 56, 105);
            lblTitle.ForeColor = Color.FromArgb(217, 234, 245);

        }

        private void pbBookCover_MouseLeave(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(217, 234, 245);
            lblTitle.ForeColor = Color.Black;
        }
    }
}
