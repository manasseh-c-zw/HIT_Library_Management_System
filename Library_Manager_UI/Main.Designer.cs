namespace Library_Manager_UI
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.designMain = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.panelMenu = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.panelMenuButtons = new Guna.UI2.WinForms.Guna2Panel();
            this.btnUsers = new FontAwesome.Sharp.IconButton();
            this.btnLoan = new FontAwesome.Sharp.IconButton();
            this.btnLibrary = new FontAwesome.Sharp.IconButton();
            this.btnHome = new FontAwesome.Sharp.IconButton();
            this.panelUser = new Guna.UI2.WinForms.Guna2Panel();
            this.lblUser = new System.Windows.Forms.Label();
            this.pbUserIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.formContainer = new System.Windows.Forms.Panel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnMinimize = new Guna.UI2.WinForms.Guna2ImageButton();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.panelMenu.SuspendLayout();
            this.panelMenuButtons.SuspendLayout();
            this.panelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // designMain
            // 
            this.designMain.BorderRadius = 12;
            this.designMain.ContainerControl = this;
            this.designMain.DockIndicatorTransparencyValue = 0.6D;
            this.designMain.DragForm = false;
            this.designMain.ResizeForm = false;
            this.designMain.TransparentWhileDrag = true;
            // 
            // panelMenu
            // 
            this.panelMenu.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.panelMenuButtons);
            this.panelMenu.Controls.Add(this.panelUser);
            this.panelMenu.FillColor = System.Drawing.Color.WhiteSmoke;
            this.panelMenu.FillColor2 = System.Drawing.Color.LightGray;
            this.panelMenu.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.ShadowDecoration.Depth = 10;
            this.panelMenu.ShadowDecoration.Enabled = true;
            this.panelMenu.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(5, 0, 0, 5);
            this.panelMenu.Size = new System.Drawing.Size(212, 840);
            this.panelMenu.TabIndex = 10;
            // 
            // panelMenuButtons
            // 
            this.panelMenuButtons.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelMenuButtons.BackColor = System.Drawing.Color.Transparent;
            this.panelMenuButtons.Controls.Add(this.btnUsers);
            this.panelMenuButtons.Controls.Add(this.btnLoan);
            this.panelMenuButtons.Controls.Add(this.btnLibrary);
            this.panelMenuButtons.Controls.Add(this.btnHome);
            this.panelMenuButtons.Location = new System.Drawing.Point(0, 182);
            this.panelMenuButtons.Name = "panelMenuButtons";
            this.panelMenuButtons.Size = new System.Drawing.Size(212, 244);
            this.panelMenuButtons.TabIndex = 0;
            // 
            // btnUsers
            // 
            this.btnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsers.FlatAppearance.BorderSize = 0;
            this.btnUsers.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsers.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsers.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.btnUsers.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.btnUsers.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUsers.IconSize = 38;
            this.btnUsers.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUsers.Location = new System.Drawing.Point(0, 180);
            this.btnUsers.Name = "btnUsers";
            this.btnUsers.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnUsers.Size = new System.Drawing.Size(212, 60);
            this.btnUsers.TabIndex = 3;
            this.btnUsers.Text = " Users";
            this.btnUsers.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUsers.UseVisualStyleBackColor = true;
            this.btnUsers.Click += new System.EventHandler(this.btnUsers_Click);
            // 
            // btnLoan
            // 
            this.btnLoan.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoan.FlatAppearance.BorderSize = 0;
            this.btnLoan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLoan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoan.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoan.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.btnLoan.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.btnLoan.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLoan.IconSize = 38;
            this.btnLoan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoan.Location = new System.Drawing.Point(0, 120);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLoan.Size = new System.Drawing.Size(212, 60);
            this.btnLoan.TabIndex = 2;
            this.btnLoan.Text = " Loan";
            this.btnLoan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnLibrary
            // 
            this.btnLibrary.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLibrary.FlatAppearance.BorderSize = 0;
            this.btnLibrary.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnLibrary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLibrary.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibrary.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnLibrary.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.btnLibrary.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLibrary.IconSize = 38;
            this.btnLibrary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLibrary.Location = new System.Drawing.Point(0, 60);
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnLibrary.Size = new System.Drawing.Size(212, 60);
            this.btnLibrary.TabIndex = 1;
            this.btnLibrary.Text = " Library";
            this.btnLibrary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.btnLibrary_Click);
            // 
            // btnHome
            // 
            this.btnHome.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.IconChar = FontAwesome.Sharp.IconChar.HomeLg;
            this.btnHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.btnHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnHome.IconSize = 38;
            this.btnHome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHome.Location = new System.Drawing.Point(0, 0);
            this.btnHome.Name = "btnHome";
            this.btnHome.Padding = new System.Windows.Forms.Padding(25, 0, 0, 0);
            this.btnHome.Size = new System.Drawing.Size(212, 60);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = " Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelUser
            // 
            this.panelUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panelUser.Controls.Add(this.lblUser);
            this.panelUser.Controls.Add(this.pbUserIcon);
            this.panelUser.Location = new System.Drawing.Point(0, 39);
            this.panelUser.Name = "panelUser";
            this.panelUser.Size = new System.Drawing.Size(209, 100);
            this.panelUser.TabIndex = 0;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(105, 41);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(61, 23);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "User1";
            // 
            // pbUserIcon
            // 
            this.pbUserIcon.Image = ((System.Drawing.Image)(resources.GetObject("pbUserIcon.Image")));
            this.pbUserIcon.ImageRotate = 0F;
            this.pbUserIcon.Location = new System.Drawing.Point(26, 18);
            this.pbUserIcon.Name = "pbUserIcon";
            this.pbUserIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbUserIcon.Size = new System.Drawing.Size(64, 64);
            this.pbUserIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbUserIcon.TabIndex = 0;
            this.pbUserIcon.TabStop = false;
            // 
            // formContainer
            // 
            this.formContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.formContainer.BackColor = System.Drawing.Color.WhiteSmoke;
            this.formContainer.Location = new System.Drawing.Point(215, 36);
            this.formContainer.Name = "formContainer";
            this.formContainer.Size = new System.Drawing.Size(1015, 790);
            this.formContainer.TabIndex = 11;
            // 
            // btnMinimize
            // 
            this.btnMinimize.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnMinimize.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            this.btnMinimize.Image = global::Library_Manager_UI.Properties.Resources._2__MinusGreenFill;
            this.btnMinimize.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnMinimize.ImageRotate = 0F;
            this.btnMinimize.ImageSize = new System.Drawing.Size(24, 24);
            this.btnMinimize.Location = new System.Drawing.Point(1170, 4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.PressedState.Image = global::Library_Manager_UI.Properties.Resources._2__Minus;
            this.btnMinimize.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnMinimize.Size = new System.Drawing.Size(28, 28);
            this.btnMinimize.TabIndex = 9;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnClose
            // 
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            this.btnClose.Image = global::Library_Manager_UI.Properties.Resources.closeRedFill;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(1204, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = global::Library_Manager_UI.Properties.Resources.closeRed;
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Size = new System.Drawing.Size(28, 28);
            this.btnClose.TabIndex = 8;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1240, 840);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.formContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.panelMenu.ResumeLayout(false);
            this.panelMenuButtons.ResumeLayout(false);
            this.panelUser.ResumeLayout(false);
            this.panelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUserIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm designMain;
        private Guna.UI2.WinForms.Guna2ImageButton btnMinimize;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2GradientPanel panelMenu;
        private System.Windows.Forms.Panel formContainer;
        private Guna.UI2.WinForms.Guna2Panel panelMenuButtons;
        private FontAwesome.Sharp.IconButton btnUsers;
        private FontAwesome.Sharp.IconButton btnLoan;
        private FontAwesome.Sharp.IconButton btnLibrary;
        private FontAwesome.Sharp.IconButton btnHome;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox pbUserIcon;
        private Guna.UI2.WinForms.Guna2Panel panelUser;
        private System.Windows.Forms.Label lblUser;
    }
}