namespace Library_Manager_UI
{
    partial class cLoan
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
            this.iconHome = new FontAwesome.Sharp.IconPictureBox();
            this.desginHome = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).BeginInit();
            this.SuspendLayout();
            // 
            // iconHome
            // 
            this.iconHome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.iconHome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.iconHome.IconChar = FontAwesome.Sharp.IconChar.BookOpenReader;
            this.iconHome.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.iconHome.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconHome.IconSize = 318;
            this.iconHome.Location = new System.Drawing.Point(337, 236);
            this.iconHome.Name = "iconHome";
            this.iconHome.Size = new System.Drawing.Size(340, 318);
            this.iconHome.TabIndex = 1;
            this.iconHome.TabStop = false;
            this.iconHome.Click += new System.EventHandler(this.iconHome_Click);
            // 
            // desginHome
            // 
            this.desginHome.ContainerControl = this;
            this.desginHome.DockIndicatorTransparencyValue = 0.6D;
            this.desginHome.TransparentWhileDrag = true;
            // 
            // cLoan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1015, 790);
            this.Controls.Add(this.iconHome);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cLoan";
            this.Text = "cLoan";
            ((System.ComponentModel.ISupportInitialize)(this.iconHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox iconHome;
        private Guna.UI2.WinForms.Guna2BorderlessForm desginHome;
    }
}