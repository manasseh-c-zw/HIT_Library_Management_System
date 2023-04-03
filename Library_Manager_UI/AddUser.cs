using HIT_Library_Manager_Lib;
using HIT_Library_Manager_Lib.Models;
using HIT_Library_Manager_Lib.Validators;
using System;
using System.Windows.Forms;

namespace Library_Manager_UI
{
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
            lbUsers.DataSource = SQliteConnector.LoadUsers();
            lbUsers.DisplayMember = "UserDetails";

        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            this.Close();

        }

        private void btnAdd_Click(object sender, System.EventArgs e)
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

            try
            {
                if (!SQliteConnector.UserExists(user.Username))
                {
                    SQliteConnector.AddUser(user);
                }
                else
                {
                    dialogError.Show("Username is taken!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ResetControls();
            lbUsers.DataSource = SQliteConnector.LoadUsers();
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
    }
}
