namespace Library_Manager_UI
{
    partial class AddBook
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
            this.designAddBook = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.grpAddBook = new Guna.UI2.WinForms.Guna2GroupBox();
            this.linkCoverImage = new System.Windows.Forms.LinkLabel();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.numBookCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtISBN = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtGenre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPublisher = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnAdd = new Guna.UI2.WinForms.Guna2Button();
            this.btnClose = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pbBookCover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblPreview = new System.Windows.Forms.Label();
            this.ipbAddBook = new FontAwesome.Sharp.IconPictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dialogSuccess = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dialogError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.txtPreTitle = new System.Windows.Forms.Label();
            this.grpAddBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBookCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbAddBook)).BeginInit();
            this.SuspendLayout();
            // 
            // designAddBook
            // 
            this.designAddBook.AnimationInterval = 100;
            this.designAddBook.BorderRadius = 10;
            this.designAddBook.ContainerControl = this;
            this.designAddBook.DockIndicatorColor = System.Drawing.Color.Gray;
            this.designAddBook.DockIndicatorTransparencyValue = 0.6D;
            this.designAddBook.DragForm = false;
            this.designAddBook.ResizeForm = false;
            this.designAddBook.TransparentWhileDrag = true;
            // 
            // grpAddBook
            // 
            this.grpAddBook.BorderRadius = 7;
            this.grpAddBook.Controls.Add(this.linkCoverImage);
            this.grpAddBook.Controls.Add(this.lblBookCount);
            this.grpAddBook.Controls.Add(this.numBookCount);
            this.grpAddBook.Controls.Add(this.txtISBN);
            this.grpAddBook.Controls.Add(this.txtGenre);
            this.grpAddBook.Controls.Add(this.txtYear);
            this.grpAddBook.Controls.Add(this.txtPublisher);
            this.grpAddBook.Controls.Add(this.txtAuthor);
            this.grpAddBook.Controls.Add(this.txtTitle);
            this.grpAddBook.Controls.Add(this.btnAdd);
            this.grpAddBook.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grpAddBook.Font = new System.Drawing.Font("Roboto Bk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(140)))), ((int)(((byte)(3)))));
            this.grpAddBook.Location = new System.Drawing.Point(40, 48);
            this.grpAddBook.Name = "grpAddBook";
            this.grpAddBook.Size = new System.Drawing.Size(542, 429);
            this.grpAddBook.TabIndex = 9;
            this.grpAddBook.Text = "ADD BOOK";
            // 
            // linkCoverImage
            // 
            this.linkCoverImage.AutoSize = true;
            this.linkCoverImage.BackColor = System.Drawing.Color.Transparent;
            this.linkCoverImage.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCoverImage.Location = new System.Drawing.Point(296, 278);
            this.linkCoverImage.Name = "linkCoverImage";
            this.linkCoverImage.Size = new System.Drawing.Size(172, 19);
            this.linkCoverImage.TabIndex = 7;
            this.linkCoverImage.TabStop = true;
            this.linkCoverImage.Text = "Select a cover image...";
            this.linkCoverImage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkCoverImage_LinkClicked);
            // 
            // lblBookCount
            // 
            this.lblBookCount.AutoSize = true;
            this.lblBookCount.BackColor = System.Drawing.Color.Transparent;
            this.lblBookCount.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCount.Location = new System.Drawing.Point(296, 207);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(99, 19);
            this.lblBookCount.TabIndex = 9;
            this.lblBookCount.Text = "Book Count: ";
            this.lblBookCount.Click += new System.EventHandler(this.lblBookCount_Click);
            // 
            // numBookCount
            // 
            this.numBookCount.BackColor = System.Drawing.Color.Transparent;
            this.numBookCount.BorderRadius = 5;
            this.numBookCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numBookCount.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBookCount.Location = new System.Drawing.Point(401, 200);
            this.numBookCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBookCount.Name = "numBookCount";
            this.numBookCount.Size = new System.Drawing.Size(99, 34);
            this.numBookCount.TabIndex = 6;
            this.numBookCount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.numBookCount.UpDownButtonForeColor = System.Drawing.Color.White;
            this.numBookCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtISBN
            // 
            this.txtISBN.BorderRadius = 5;
            this.txtISBN.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtISBN.DefaultText = "";
            this.txtISBN.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtISBN.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtISBN.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtISBN.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtISBN.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtISBN.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txtISBN.ForeColor = System.Drawing.Color.Black;
            this.txtISBN.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtISBN.Location = new System.Drawing.Point(300, 131);
            this.txtISBN.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtISBN.Name = "txtISBN";
            this.txtISBN.PasswordChar = '\0';
            this.txtISBN.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtISBN.PlaceholderText = "ISBN(optional)";
            this.txtISBN.SelectedText = "";
            this.txtISBN.Size = new System.Drawing.Size(200, 34);
            this.txtISBN.TabIndex = 5;
            // 
            // txtGenre
            // 
            this.txtGenre.BorderRadius = 5;
            this.txtGenre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGenre.DefaultText = "";
            this.txtGenre.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtGenre.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtGenre.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenre.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtGenre.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenre.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txtGenre.ForeColor = System.Drawing.Color.Black;
            this.txtGenre.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtGenre.Location = new System.Drawing.Point(300, 66);
            this.txtGenre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.PasswordChar = '\0';
            this.txtGenre.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtGenre.PlaceholderText = "Genre";
            this.txtGenre.SelectedText = "";
            this.txtGenre.Size = new System.Drawing.Size(200, 34);
            this.txtGenre.TabIndex = 4;
            // 
            // txtYear
            // 
            this.txtYear.BorderRadius = 5;
            this.txtYear.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtYear.DefaultText = "";
            this.txtYear.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtYear.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtYear.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txtYear.ForeColor = System.Drawing.Color.Black;
            this.txtYear.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtYear.Location = new System.Drawing.Point(48, 267);
            this.txtYear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.PasswordChar = '\0';
            this.txtYear.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtYear.PlaceholderText = "Year";
            this.txtYear.SelectedText = "";
            this.txtYear.Size = new System.Drawing.Size(200, 34);
            this.txtYear.TabIndex = 3;
            // 
            // txtPublisher
            // 
            this.txtPublisher.BorderRadius = 5;
            this.txtPublisher.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPublisher.DefaultText = "";
            this.txtPublisher.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPublisher.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPublisher.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPublisher.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPublisher.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPublisher.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txtPublisher.ForeColor = System.Drawing.Color.Black;
            this.txtPublisher.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPublisher.Location = new System.Drawing.Point(48, 200);
            this.txtPublisher.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPublisher.Name = "txtPublisher";
            this.txtPublisher.PasswordChar = '\0';
            this.txtPublisher.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtPublisher.PlaceholderText = "Publisher";
            this.txtPublisher.SelectedText = "";
            this.txtPublisher.Size = new System.Drawing.Size(200, 34);
            this.txtPublisher.TabIndex = 2;
            // 
            // txtAuthor
            // 
            this.txtAuthor.BorderRadius = 5;
            this.txtAuthor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtAuthor.DefaultText = "";
            this.txtAuthor.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtAuthor.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtAuthor.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthor.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtAuthor.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthor.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txtAuthor.ForeColor = System.Drawing.Color.Black;
            this.txtAuthor.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtAuthor.Location = new System.Drawing.Point(48, 133);
            this.txtAuthor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.PasswordChar = '\0';
            this.txtAuthor.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtAuthor.PlaceholderText = "Author";
            this.txtAuthor.SelectedText = "";
            this.txtAuthor.Size = new System.Drawing.Size(200, 34);
            this.txtAuthor.TabIndex = 1;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderRadius = 5;
            this.txtTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTitle.DefaultText = "";
            this.txtTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txtTitle.ForeColor = System.Drawing.Color.Black;
            this.txtTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTitle.Location = new System.Drawing.Point(48, 66);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTitle.PlaceholderText = "Title";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(200, 34);
            this.txtTitle.TabIndex = 0;
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
            this.btnAdd.Location = new System.Drawing.Point(214, 355);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(115, 40);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "ADD";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.btnClose.HoverState.ImageSize = new System.Drawing.Size(26, 26);
            this.btnClose.Image = global::Library_Manager_UI.Properties.Resources.closeRedFill;
            this.btnClose.ImageOffset = new System.Drawing.Point(0, 0);
            this.btnClose.ImageRotate = 0F;
            this.btnClose.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Location = new System.Drawing.Point(773, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.PressedState.Image = global::Library_Manager_UI.Properties.Resources.closeRed;
            this.btnClose.PressedState.ImageSize = new System.Drawing.Size(24, 24);
            this.btnClose.Size = new System.Drawing.Size(34, 34);
            this.btnClose.TabIndex = 8;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            // 
            // pbBookCover
            // 
            this.pbBookCover.BackColor = System.Drawing.Color.Transparent;
            this.pbBookCover.BorderRadius = 5;
            this.pbBookCover.ImageRotate = 0F;
            this.pbBookCover.Location = new System.Drawing.Point(635, 142);
            this.pbBookCover.Margin = new System.Windows.Forms.Padding(4);
            this.pbBookCover.Name = "pbBookCover";
            this.pbBookCover.ShadowDecoration.Enabled = true;
            this.pbBookCover.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1);
            this.pbBookCover.Size = new System.Drawing.Size(132, 140);
            this.pbBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBookCover.TabIndex = 10;
            this.pbBookCover.TabStop = false;
            // 
            // lblPreview
            // 
            this.lblPreview.AutoSize = true;
            this.lblPreview.BackColor = System.Drawing.Color.Transparent;
            this.lblPreview.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreview.ForeColor = System.Drawing.Color.Silver;
            this.lblPreview.Location = new System.Drawing.Point(631, 119);
            this.lblPreview.Name = "lblPreview";
            this.lblPreview.Size = new System.Drawing.Size(65, 19);
            this.lblPreview.TabIndex = 12;
            this.lblPreview.Text = "Preview";
            // 
            // ipbAddBook
            // 
            this.ipbAddBook.BackColor = System.Drawing.Color.Transparent;
            this.ipbAddBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.ipbAddBook.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            this.ipbAddBook.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.ipbAddBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ipbAddBook.IconSize = 85;
            this.ipbAddBook.Location = new System.Drawing.Point(652, 367);
            this.ipbAddBook.Name = "ipbAddBook";
            this.ipbAddBook.Size = new System.Drawing.Size(94, 85);
            this.ipbAddBook.TabIndex = 13;
            this.ipbAddBook.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg;*.png;*.gif)|*.bmp;*.jpg;*.jpeg;*.png;*";
            this.openFileDialog1.InitialDirectory = "Environment.SpecialFolder.MyPictures";
            // 
            // dialogSuccess
            // 
            this.dialogSuccess.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogSuccess.Caption = "Add User";
            this.dialogSuccess.Icon = Guna.UI2.WinForms.MessageDialogIcon.Information;
            this.dialogSuccess.Parent = null;
            this.dialogSuccess.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.dialogSuccess.Text = "User Added";
            // 
            // dialogError
            // 
            this.dialogError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogError.Caption = "Add User";
            this.dialogError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.dialogError.Parent = null;
            this.dialogError.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.dialogError.Text = "Error!";
            // 
            // txtPreTitle
            // 
            this.txtPreTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPreTitle.AutoEllipsis = true;
            this.txtPreTitle.BackColor = System.Drawing.Color.Transparent;
            this.txtPreTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(140)))), ((int)(((byte)(3)))));
            this.txtPreTitle.Location = new System.Drawing.Point(640, 286);
            this.txtPreTitle.Name = "txtPreTitle";
            this.txtPreTitle.Size = new System.Drawing.Size(123, 19);
            this.txtPreTitle.TabIndex = 14;
            this.txtPreTitle.Text = "Title";
            this.txtPreTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(812, 525);
            this.Controls.Add(this.txtPreTitle);
            this.Controls.Add(this.ipbAddBook);
            this.Controls.Add(this.lblPreview);
            this.Controls.Add(this.grpAddBook);
            this.Controls.Add(this.pbBookCover);
            this.Controls.Add(this.btnClose);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBook";
            this.Activated += new System.EventHandler(this.AddBook_Activated);
            this.grpAddBook.ResumeLayout(false);
            this.grpAddBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBookCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ipbAddBook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm designAddBook;
        private Guna.UI2.WinForms.Guna2ImageButton btnClose;
        private Guna.UI2.WinForms.Guna2GroupBox grpAddBook;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2Button btnAdd;
        private Guna.UI2.WinForms.Guna2TextBox txtISBN;
        private Guna.UI2.WinForms.Guna2TextBox txtGenre;
        private Guna.UI2.WinForms.Guna2TextBox txtYear;
        private Guna.UI2.WinForms.Guna2TextBox txtPublisher;
        private Guna.UI2.WinForms.Guna2TextBox txtAuthor;
        private System.Windows.Forms.Label lblBookCount;
        private Guna.UI2.WinForms.Guna2NumericUpDown numBookCount;
        private Guna.UI2.WinForms.Guna2PictureBox pbBookCover;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Label lblPreview;
        private System.Windows.Forms.LinkLabel linkCoverImage;
        private FontAwesome.Sharp.IconPictureBox ipbAddBook;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogSuccess;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogError;
        private System.Windows.Forms.Label txtPreTitle;
    }
}