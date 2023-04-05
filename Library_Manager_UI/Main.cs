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
        private Form currentChildForm;


        public Main()
        {
            InitializeComponent();


            leftBorderBtn = new Guna2GradientPanel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenuButtons.Controls.Add(leftBorderBtn);

            ActivateButton(btnHome);
            OpenChildForm(new cHome());
        }

        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            formContainer.Controls.Add(childForm);
            formContainer.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();


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


        private void btnHome_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender);
            currentChildForm.Close();
            OpenChildForm(new cHome());
        }

        private void btnLibrary_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender);
            currentChildForm.Close();
            OpenChildForm(new cLibrary());
        }

        private void btnLoan_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender);
            currentChildForm.Close();
            OpenChildForm(new cLoan());
        }

        private void btnUsers_Click(object sender, System.EventArgs e)
        {
            ActivateButton(sender);
            currentChildForm.Close();
            OpenChildForm(new cUsers());
        }
    }
}
