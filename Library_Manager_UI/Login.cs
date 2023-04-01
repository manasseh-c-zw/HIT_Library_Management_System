using HIT_Library_Manager_Lib;
using System;
using System.Windows.Forms;

namespace Library_Manager_UI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            var newUser = new AddUser();
            newUser.ShowDialog();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (SQliteConnector.AuthenticateUser(txtUsername.Text, txtPassword.Text))
            {
                dialogSuccess.Show();

            }
            else
            {
                dialogError.Show();
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void chPass_CheckedChanged(object sender, EventArgs e)
        {
            if (chPass.Checked)
            {
                //TODO: add show/hide pass functionality

            }

        }
    }
}
