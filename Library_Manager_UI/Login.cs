using HIT_Library_Manager_Lib;
using HIT_Library_Manager_Lib.Models;
using HIT_Library_Manager_Lib.Validators;
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
            var user = new UserModel()
            {
                Username = txtUsername.Text,
                Password = txtPassword.Text
            };

            //Validate the user
            UserValidator validator = new UserValidator();
            var results = validator.Validate(user);

            if (!results.IsValid)
            {
                foreach (var failure in results.Errors)
                {
                    dialogError.Show(failure.ErrorMessage);

                }
                ResetControls();
                return;
            }

            if (SQliteConnector.AuthenticateUser(user.Username, user.Password))
            {
                dialogSuccess.Show();
                ResetControls();
            }
            else
            {
                dialogError.Show("Authentication Error!");
                ResetControls();
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
                txtPassword.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '●';
            }

        }

        /// <summary>
        /// Resets the controls and sets the focus to the username field.
        /// </summary>
        public void ResetControls()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }
}
