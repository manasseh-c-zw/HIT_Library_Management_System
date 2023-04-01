namespace Library_Manager_UI
{
    partial class AddUser
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.designUserAccounts = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.grpAddUser = new Guna.UI2.WinForms.Guna2GroupBox();
            this.lbUsers = new System.Windows.Forms.ListBox();
            this.grpUsers = new Guna.UI2.WinForms.Guna2GroupBox();
            this.dialogError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dialogSuccess = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.ipbAddUser = new FontAwesome.Sharp.IconPictureBox();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.chPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.grpAddUser.SuspendLayout();
            this.grpUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ipbAddUser)).BeginInit();
            this.SuspendLayout();
            // 
            // designUserAccounts
            // 
            this.designUserAccounts.BorderRadius = 10;
            this.designUserAccounts.ContainerControl = this;
            this.designUserAccounts.DockIndicatorTransparencyValue = 0.6D;
            this.designUserAccounts.ResizeForm = false;
            this.designUserAccounts.TransparentWhileDrag = true;
            // 
            // txtUsername
            // 
            this.txtUsername.BorderRadius = 5;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.DefaultText = "";
            this.txtUsername.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUsername.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUsername.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUsername.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUsername.Location = new System.Drawing.Point(48, 81);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtUsername.PlaceholderText = "Username";
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(200, 34);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.BorderRadius = 5;
            this.txtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPassword.DefaultText = "";
            this.txtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txtPassword.ForeColor = System.Drawing.Color.Black;
            this.txtPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPassword.Location = new System.Drawing.Point(48, 171);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPassword.PlaceholderText = "Password";
            this.txtPassword.SelectedText = "";
            this.txtPassword.Size = new System.Drawing.Size(200, 34);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // btnAdd
            // 
            this.btnAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.btnAdd.BorderRadius = 5;
            this.btnAdd.BorderThickness = 1;
            this.btnAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAdd.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(91, 261);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 40);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grpAddUser
            // 
            this.grpAddUser.BorderRadius = 7;
            this.grpAddUser.Controls.Add(this.chPass);
            this.grpAddUser.Controls.Add(this.txtUsername);
            this.grpAddUser.Controls.Add(this.btnAdd);
            this.grpAddUser.Controls.Add(this.txtPassword);
            this.grpAddUser.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grpAddUser.Font = new System.Drawing.Font("Roboto Bk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(140)))), ((int)(((byte)(3)))));
            this.grpAddUser.Location = new System.Drawing.Point(49, 46);
            this.grpAddUser.Name = "grpAddUser";
            this.grpAddUser.Size = new System.Drawing.Size(300, 349);
            this.grpAddUser.TabIndex = 3;
            this.grpAddUser.Text = "ADD USER";
            // 
            // lbUsers
            // 
            this.lbUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbUsers.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsers.FormattingEnabled = true;
            this.lbUsers.ItemHeight = 18;
            this.lbUsers.Location = new System.Drawing.Point(3, 35);
            this.lbUsers.Name = "lbUsers";
            this.lbUsers.Size = new System.Drawing.Size(206, 162);
            this.lbUsers.TabIndex = 4;
            // 
            // grpUsers
            // 
            this.grpUsers.BorderRadius = 7;
            this.grpUsers.Controls.Add(this.lbUsers);
            this.grpUsers.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grpUsers.Font = new System.Drawing.Font("Roboto Bk", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(140)))), ((int)(((byte)(3)))));
            this.grpUsers.Location = new System.Drawing.Point(395, 46);
            this.grpUsers.Name = "grpUsers";
            this.grpUsers.Size = new System.Drawing.Size(210, 205);
            this.grpUsers.TabIndex = 5;
            this.grpUsers.Text = "USERS";
            // 
            // dialogError
            // 
            this.dialogError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogError.Caption = "Login";
            this.dialogError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.dialogError.Parent = null;
            this.dialogError.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.dialogError.Text = "Authentication Error!";
            // 
            // dialogSuccess
            // 
            this.dialogSuccess.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogSuccess.Caption = "Login";
            this.dialogSuccess.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.dialogSuccess.Parent = null;
            this.dialogSuccess.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.dialogSuccess.Text = "Logged in";
            // 
            // ipbAddUser
            // 
            this.ipbAddUser.BackColor = System.Drawing.Color.Transparent;
            this.ipbAddUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.ipbAddUser.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.ipbAddUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.ipbAddUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbAddUser.IconSize = 85;
            this.ipbAddUser.Location = new System.Drawing.Point(452, 288);
            this.ipbAddUser.Name = "ipbAddUser";
            this.ipbAddUser.Size = new System.Drawing.Size(94, 85);
            this.ipbAddUser.TabIndex = 8;
            this.ipbAddUser.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            this.btnClose.Image = global::Library_Manager_UI.Properties.Resources.closeRedFill;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(628, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = global::Library_Manager_UI.Properties.Resources.closeRed;
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Size = new System.Drawing.Size(34, 34);
            this.btnClose.TabIndex = 7;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // chPass
            // 
            this.chPass.AutoSize = true;
            this.chPass.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.chPass.CheckedState.BorderRadius = 4;
            this.chPass.CheckedState.BorderThickness = 1;
            this.chPass.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.chPass.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.chPass.Location = new System.Drawing.Point(224, 181);
            this.chPass.Name = "chPass";
            this.chPass.Size = new System.Drawing.Size(15, 14);
            this.chPass.TabIndex = 4;
            this.chPass.UncheckedState.BorderColor = System.Drawing.Color.SlateBlue;
            this.chPass.UncheckedState.BorderRadius = 4;
            this.chPass.UncheckedState.BorderThickness = 0;
            this.chPass.UncheckedState.FillColor = System.Drawing.Color.Gainsboro;
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(665, 447);
            this.ControlBox = false;
            this.Controls.Add(this.ipbAddUser);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpUsers);
            this.Controls.Add(this.grpAddUser);
            this.Font = new System.Drawing.Font("Roboto Bk", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UICreate_Account";
            this.grpAddUser.ResumeLayout(false);
            this.grpAddUser.PerformLayout();
            this.grpUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ipbAddUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm designUserAccounts;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2GroupBox grpAddUser;
        private Guna.UI2.WinForms.Guna2GroupBox grpUsers;
        private System.Windows.Forms.ListBox lbUsers;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private FontAwesome.Sharp.IconPictureBox ipbAddUser;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogError;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogSuccess;
        private Guna.UI2.WinForms.Guna2CheckBox chPass;
    }
}