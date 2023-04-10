namespace Library_Manager_UI
{
    partial class cLibrary
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
            this.desginLibrary = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.fpanelBooks = new System.Windows.Forms.FlowLayoutPanel();
            this.panelBookPreview = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.btnSearch = new FontAwesome.Sharp.IconButton();
            this.cmbFilter = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddBook = new FontAwesome.Sharp.IconButton();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.grpEditBook = new Guna.UI2.WinForms.Guna2GroupBox();
            this.numBookCount = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.pbBookCover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.linkCoverImage = new System.Windows.Forms.LinkLabel();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.txtGenre = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtYear = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPublisher = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtAuthor = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.dialogError = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dialogSuccess = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.dialogAsk = new Guna.UI2.WinForms.Guna2MessageDialog();
            this.grpEditBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBookCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // desginLibrary
            // 
            this.desginLibrary.ContainerControl = this;
            this.desginLibrary.DockIndicatorTransparencyValue = 0.6D;
            this.desginLibrary.TransparentWhileDrag = true;
            // 
            // fpanelBooks
            // 
            this.fpanelBooks.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fpanelBooks.AutoScroll = true;
            this.fpanelBooks.Location = new System.Drawing.Point(2, 137);
            this.fpanelBooks.Name = "fpanelBooks";
            this.fpanelBooks.Size = new System.Drawing.Size(770, 650);
            this.fpanelBooks.TabIndex = 0;
            // 
            // panelBookPreview
            // 
            this.panelBookPreview.BackColor = System.Drawing.Color.GhostWhite;
            this.panelBookPreview.Location = new System.Drawing.Point(778, 137);
            this.panelBookPreview.Name = "panelBookPreview";
            this.panelBookPreview.Size = new System.Drawing.Size(235, 650);
            this.panelBookPreview.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderRadius = 5;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.txtSearch.ForeColor = System.Drawing.Color.Black;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Location = new System.Drawing.Point(382, 83);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.PlaceholderText = "Type here to search";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(200, 36);
            this.txtSearch.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 5;
            this.guna2Elipse1.TargetControl = this.btnSearch;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.btnSearch.FlatAppearance.BorderSize = 0;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnSearch.IconColor = System.Drawing.Color.White;
            this.btnSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSearch.IconSize = 28;
            this.btnSearch.Location = new System.Drawing.Point(726, 83);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(40, 36);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbFilter
            // 
            this.cmbFilter.BackColor = System.Drawing.Color.Transparent;
            this.cmbFilter.BorderRadius = 5;
            this.cmbFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilter.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilter.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cmbFilter.Font = new System.Drawing.Font("Roboto", 12F);
            this.cmbFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cmbFilter.ItemHeight = 30;
            this.cmbFilter.Items.AddRange(new object[] {
            "Title",
            "Author",
            "Publisher",
            "Genre",
            "Year"});
            this.cmbFilter.Location = new System.Drawing.Point(589, 83);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(131, 36);
            this.cmbFilter.StartIndex = 0;
            this.cmbFilter.TabIndex = 11;
            // 
            // btnAddBook
            // 
            this.btnAddBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.btnAddBook.FlatAppearance.BorderSize = 0;
            this.btnAddBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddBook.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddBook.ForeColor = System.Drawing.Color.White;
            this.btnAddBook.IconChar = FontAwesome.Sharp.IconChar.Book;
            this.btnAddBook.IconColor = System.Drawing.Color.Goldenrod;
            this.btnAddBook.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddBook.IconSize = 26;
            this.btnAddBook.Location = new System.Drawing.Point(12, 83);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(117, 39);
            this.btnAddBook.TabIndex = 12;
            this.btnAddBook.Text = "Add Book";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 5;
            this.guna2Elipse2.TargetControl = this.btnAddBook;
            // 
            // grpEditBook
            // 
            this.grpEditBook.BackColor = System.Drawing.Color.Transparent;
            this.grpEditBook.BorderRadius = 7;
            this.grpEditBook.Controls.Add(this.numBookCount);
            this.grpEditBook.Controls.Add(this.pbBookCover);
            this.grpEditBook.Controls.Add(this.linkCoverImage);
            this.grpEditBook.Controls.Add(this.lblBookCount);
            this.grpEditBook.Controls.Add(this.txtGenre);
            this.grpEditBook.Controls.Add(this.txtYear);
            this.grpEditBook.Controls.Add(this.txtPublisher);
            this.grpEditBook.Controls.Add(this.txtAuthor);
            this.grpEditBook.Controls.Add(this.txtTitle);
            this.grpEditBook.Controls.Add(this.btnSave);
            this.grpEditBook.CustomBorderThickness = new System.Windows.Forms.Padding(0);
            this.grpEditBook.Enabled = false;
            this.grpEditBook.Font = new System.Drawing.Font("Roboto Bk", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpEditBook.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(140)))), ((int)(((byte)(3)))));
            this.grpEditBook.Location = new System.Drawing.Point(778, 137);
            this.grpEditBook.Name = "grpEditBook";
            this.grpEditBook.ShadowDecoration.Enabled = true;
            this.grpEditBook.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1);
            this.grpEditBook.Size = new System.Drawing.Size(232, 647);
            this.grpEditBook.TabIndex = 10;
            this.grpEditBook.Text = "Edit Meta Data";
            this.grpEditBook.Leave += new System.EventHandler(this.grpAddBook_Leave);
            // 
            // numBookCount
            // 
            this.numBookCount.BackColor = System.Drawing.Color.Transparent;
            this.numBookCount.BorderRadius = 5;
            this.numBookCount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numBookCount.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numBookCount.IndicateFocus = true;
            this.numBookCount.Location = new System.Drawing.Point(125, 515);
            this.numBookCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numBookCount.Name = "numBookCount";
            this.numBookCount.Size = new System.Drawing.Size(89, 30);
            this.numBookCount.TabIndex = 11;
            this.numBookCount.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.numBookCount.UpDownButtonForeColor = System.Drawing.Color.White;
            this.numBookCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // pbBookCover
            // 
            this.pbBookCover.BackColor = System.Drawing.Color.Transparent;
            this.pbBookCover.BorderRadius = 5;
            this.pbBookCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBookCover.FillColor = System.Drawing.Color.WhiteSmoke;
            this.pbBookCover.ImageRotate = 0F;
            this.pbBookCover.Location = new System.Drawing.Point(48, 42);
            this.pbBookCover.Margin = new System.Windows.Forms.Padding(4);
            this.pbBookCover.Name = "pbBookCover";
            this.pbBookCover.ShadowDecoration.Enabled = true;
            this.pbBookCover.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1);
            this.pbBookCover.Size = new System.Drawing.Size(132, 140);
            this.pbBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBookCover.TabIndex = 10;
            this.pbBookCover.TabStop = false;
            // 
            // linkCoverImage
            // 
            this.linkCoverImage.AutoSize = true;
            this.linkCoverImage.BackColor = System.Drawing.Color.Transparent;
            this.linkCoverImage.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkCoverImage.Location = new System.Drawing.Point(45, 186);
            this.linkCoverImage.Name = "linkCoverImage";
            this.linkCoverImage.Size = new System.Drawing.Size(138, 18);
            this.linkCoverImage.TabIndex = 7;
            this.linkCoverImage.TabStop = true;
            this.linkCoverImage.Text = "New cover image...";
            // 
            // lblBookCount
            // 
            this.lblBookCount.AutoSize = true;
            this.lblBookCount.BackColor = System.Drawing.Color.Transparent;
            this.lblBookCount.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBookCount.Location = new System.Drawing.Point(18, 520);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(99, 19);
            this.lblBookCount.TabIndex = 9;
            this.lblBookCount.Text = "Book Count: ";
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
            this.txtGenre.Location = new System.Drawing.Point(14, 460);
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
            this.txtYear.Location = new System.Drawing.Point(14, 405);
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
            this.txtPublisher.Location = new System.Drawing.Point(14, 345);
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
            this.txtAuthor.Location = new System.Drawing.Point(14, 291);
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
            this.txtTitle.Location = new System.Drawing.Point(14, 236);
            this.txtTitle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PasswordChar = '\0';
            this.txtTitle.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtTitle.PlaceholderText = "Title";
            this.txtTitle.SelectedText = "";
            this.txtTitle.Size = new System.Drawing.Size(200, 34);
            this.txtTitle.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.btnSave.BorderRadius = 5;
            this.btnSave.BorderThickness = 1;
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.btnSave.Font = new System.Drawing.Font("Roboto", 11.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(57, 579);
            this.btnSave.Name = "btnSave";
            this.btnSave.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(2);
            this.btnSave.Size = new System.Drawing.Size(115, 40);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "SAVE";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dialogError
            // 
            this.dialogError.Buttons = Guna.UI2.WinForms.MessageDialogButtons.OK;
            this.dialogError.Caption = "Edit Book";
            this.dialogError.Icon = Guna.UI2.WinForms.MessageDialogIcon.Error;
            this.dialogError.Parent = null;
            this.dialogError.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.dialogError.Text = "Error!";
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
            // dialogAsk
            // 
            this.dialogAsk.Buttons = Guna.UI2.WinForms.MessageDialogButtons.YesNoCancel;
            this.dialogAsk.Caption = "Edit Book";
            this.dialogAsk.Icon = Guna.UI2.WinForms.MessageDialogIcon.Question;
            this.dialogAsk.Parent = null;
            this.dialogAsk.Style = Guna.UI2.WinForms.MessageDialogStyle.Light;
            this.dialogAsk.Text = "Ask";
            // 
            // cLibrary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1015, 790);
            this.Controls.Add(this.grpEditBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panelBookPreview);
            this.Controls.Add(this.fpanelBooks);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cLibrary";
            this.Text = "cLibrary";
            this.Load += new System.EventHandler(this.cLibrary_Load);
            this.grpEditBook.ResumeLayout(false);
            this.grpEditBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numBookCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2BorderlessForm desginLibrary;
        private Guna.UI2.WinForms.Guna2Panel panelBookPreview;
        private System.Windows.Forms.FlowLayoutPanel fpanelBooks;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2ComboBox cmbFilter;
        private FontAwesome.Sharp.IconButton btnAddBook;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2GroupBox grpEditBook;
        private System.Windows.Forms.LinkLabel linkCoverImage;
        private System.Windows.Forms.Label lblBookCount;
        private Guna.UI2.WinForms.Guna2TextBox txtGenre;
        private Guna.UI2.WinForms.Guna2TextBox txtYear;
        private Guna.UI2.WinForms.Guna2TextBox txtPublisher;
        private Guna.UI2.WinForms.Guna2TextBox txtAuthor;
        private Guna.UI2.WinForms.Guna2TextBox txtTitle;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2PictureBox pbBookCover;
        private FontAwesome.Sharp.IconButton btnSearch;
        private Guna.UI2.WinForms.Guna2NumericUpDown numBookCount;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogError;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogSuccess;
        private Guna.UI2.WinForms.Guna2MessageDialog dialogAsk;
    }
}