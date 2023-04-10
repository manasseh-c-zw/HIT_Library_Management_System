namespace Library_Manager_UI.Components
{
    partial class BookCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.pbBookCover = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // pbBookCover
            // 
            this.pbBookCover.BackColor = System.Drawing.Color.Transparent;
            this.pbBookCover.BorderRadius = 5;
            this.pbBookCover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBookCover.ImageRotate = 0F;
            this.pbBookCover.Location = new System.Drawing.Point(4, 4);
            this.pbBookCover.Margin = new System.Windows.Forms.Padding(4);
            this.pbBookCover.Name = "pbBookCover";
            this.pbBookCover.ShadowDecoration.Enabled = true;
            this.pbBookCover.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(1);
            this.pbBookCover.Size = new System.Drawing.Size(132, 140);
            this.pbBookCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBookCover.TabIndex = 0;
            this.pbBookCover.TabStop = false;
            this.pbBookCover.Click += new System.EventHandler(this.pbBookCover_Click);
            this.pbBookCover.MouseLeave += new System.EventHandler(this.pbBookCover_MouseLeave);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTitle.AutoEllipsis = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Location = new System.Drawing.Point(9, 155);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(123, 19);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "label1";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BookCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(234)))), ((int)(((byte)(245)))));
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pbBookCover);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookCard";
            this.Size = new System.Drawing.Size(140, 182);
            ((System.ComponentModel.ISupportInitialize)(this.pbBookCover)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2PictureBox pbBookCover;
        private System.Windows.Forms.Label lblTitle;
    }
}
