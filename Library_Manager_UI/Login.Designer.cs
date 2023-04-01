namespace Library_Manager_UI
{
    partial class Login
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
            this.grpLogin = new Guna.UI2.WinForms.Guna2GroupBox();
            this.txtUsername = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnLogin = new Guna.UI2.WinForms.Guna2Button();
            this.txtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.designLogin = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.dialogSuccess = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dialogError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.btnCreateAccount = new FontAwesome.Sharp.IconButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.pbLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.chPass = new Guna.UI2.WinForms.Guna2CheckBox();
            this.grpLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLogin
            // 
            this.grpLogin.BorderRadius = 7;
            this.grpLogin.Controls.Add(this.chPass);
            this.grpLogin.Controls.Add(this.txtUsername);
            this.grpLogin.Controls.Add(this.btnLogin);
            this.grpLogin.Controls.Add(this.txtPassword);
            this.grpLogin.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grpLogin.Font = new System.Drawing.Font("Roboto Bk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpLogin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(140)))), ((int)(((byte)(3)))));
            this.grpLogin.Location = new System.Drawing.Point(309, 49);
            this.grpLogin.Name = "grpLogin";
            this.grpLogin.Size = new System.Drawing.Size(294, 349);
            this.grpLogin.TabIndex = 4;
            this.grpLogin.Text = "LOGIN";
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
            // btnLogin
            // 
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.btnLogin.BorderRadius = 5;
            this.btnLogin.BorderThickness = 1;
            this.btnLogin.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogin.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.btnLogin.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.btnLogin.ForeColor = System.Drawing.Color.White;
            this.btnLogin.Location = new System.Drawing.Point(91, 261);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(115, 40);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
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
            // 
            // designLogin
            // 
            this.designLogin.BorderRadius = 10;
            this.designLogin.ContainerControl = this;
            this.designLogin.DockIndicatorTransparencyValue = 0.6D;
            this.designLogin.DragForm = false;
            this.designLogin.ResizeForm = false;
            this.designLogin.TransparentWhileDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 10;
            this.guna2Elipse1.TargetControl = this.btnCreateAccount;
            // 
            // dialogSuccess
            // 
            this.dialogSuccess.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogSuccess.Caption = "Login";
            this.dialogSuccess.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.dialogSuccess.Parent = this;
            this.dialogSuccess.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.dialogSuccess.Text = "Logged in";
            // 
            // dialogError
            // 
            this.dialogError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogError.Caption = "Login";
            this.dialogError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.dialogError.Parent = this;
            this.dialogError.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.dialogError.Text = "Authentication Error!";
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.BackColor = System.Drawing.Color.Goldenrod;
            this.btnCreateAccount.FlatAppearance.BorderSize = 0;
            this.btnCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAccount.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAccount.ForeColor = System.Drawing.Color.White;
            this.btnCreateAccount.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnCreateAccount.IconColor = System.Drawing.Color.MediumBlue;
            this.btnCreateAccount.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCreateAccount.IconSize = 40;
            this.btnCreateAccount.Location = new System.Drawing.Point(74, 282);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.Size = new System.Drawing.Size(159, 46);
            this.btnCreateAccount.TabIndex = 9;
            this.btnCreateAccount.Text = "Create Account";
            this.btnCreateAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCreateAccount.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateAccount.UseVisualStyleBackColor = false;
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            this.btnClose.Image = global::Library_Manager_UI.Properties.Resources.closeRedFill;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(629, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = global::Library_Manager_UI.Properties.Resources.closeRed;
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Size = new System.Drawing.Size(34, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pbLogo
            // 
            this.pbLogo.BorderRadius = 7;
            this.pbLogo.Image = global::Library_Manager_UI.Properties.Resources.HIT_logo;
            this.pbLogo.ImageRotate = 0F;
            this.pbLogo.Location = new System.Drawing.Point(52, 49);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(203, 164);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbLogo.TabIndex = 5;
            this.pbLogo.TabStop = false;
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
            this.chPass.TabIndex = 3;
            this.chPass.UncheckedState.BorderColor = System.Drawing.Color.SlateBlue;
            this.chPass.UncheckedState.BorderRadius = 4;
            this.chPass.UncheckedState.BorderThickness = 0;
            this.chPass.UncheckedState.FillColor = System.Drawing.Color.Gainsboro;
            this.chPass.CheckedChanged += new System.EventHandler(this.chPass_CheckedChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 447);
            this.Controls.Add(this.btnCreateAccount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.grpLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.grpLogin.ResumeLayout(false);
            this.grpLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox grpLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtUsername;
        private Guna.UI2.WinForms.Guna2Button btnLogin;
        private Guna.UI2.WinForms.Guna2TextBox txtPassword;
        private Guna.UI2.WinForms.Guna2BorderlessForm designLogin;
        private Guna.UI2.WinForms.Guna2PictureBox pbLogo;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private FontAwesome.Sharp.IconButton btnCreateAccount;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogSuccess;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogError;
        private Guna.UI2.WinForms.Guna2CheckBox chPass;
    }
}