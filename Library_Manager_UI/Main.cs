using FontAwesome.Sharp;
using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;
namespace Library_Manager_UI
{
    public partial class Main : Form
    {
        private IconButton currentBtn;
        private Guna2GradientPanel leftBorderBtn;

        public string loggedInUser { get; set; }

        public Main()
        {
            InitializeComponent();


            leftBorderBtn = new Guna2GradientPanel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenuButtons.Controls.Add(leftBorderBtn);
        }

        public Main(string user)
        {
            lblUser.Text = user;
        }

        private void ActivateButton(object senderBtn)
        {
            if (senderBtn != null)
            {
                DisableButton();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.Gainsboro;
                leftBorderBtn.BackColor = Color.FromArgb(55, 64, 179);
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = DefaultBackColor;
                leftBorderBtn.BackColor = DefaultBackColor;
                leftBorderBtn.Visible = false;
                leftBorderBtn.Hide();
            }
        }


        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, System.EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void formContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnLibrary_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnLoan_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender);
        }

        private void btnUsers_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender);
        }
    }
}
