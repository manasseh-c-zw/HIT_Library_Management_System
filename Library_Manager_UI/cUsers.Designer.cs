namespace Library_Manager_UI
{
    partial class cUsers
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
            this.designUsers = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.iconUser = new FontAwesome.Sharp.IconPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).BeginInit();
            this.SuspendLayout();
            // 
            // designUsers
            // 
            this.designUsers.ContainerControl = this;
            this.designUsers.DockIndicatorTransparencyValue = 0.6D;
            this.designUsers.TransparentWhileDrag = true;
            // 
            // iconUser
            // 
            this.iconUser.BackColor = System.Drawing.SystemColors.Control;
            this.iconUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.iconUser.IconChar = FontAwesome.Sharp.IconChar.UserGear;
            this.iconUser.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.iconUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconUser.IconSize = 318;
            this.iconUser.Location = new System.Drawing.Point(337, 236);
            this.iconUser.Name = "iconUser";
            this.iconUser.Size = new System.Drawing.Size(340, 318);
            this.iconUser.TabIndex = 0;
            this.iconUser.TabStop = false;
            // 
            // cUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1015, 790);
            this.Controls.Add(this.iconUser);
            this.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "cUsers";
            this.Text = "cUsers";
            ((System.ComponentModel.ISupportInitialize)(this.iconUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm designUsers;
        private FontAwesome.Sharp.IconPictureBox iconUser;
    }
}