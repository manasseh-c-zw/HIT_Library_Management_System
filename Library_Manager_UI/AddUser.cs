using HIT_Library_Manager_Lib;
using HIT_Library_Manager_Lib.Models;
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

            try
            {
                SQliteConnector.AddUser(user);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            ResetControls();
            lbUsers.DataSource = SQliteConnector.LoadUsers();
        }

        public void ResetControls()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            txtUsername.Focus();
        }
    }
}
