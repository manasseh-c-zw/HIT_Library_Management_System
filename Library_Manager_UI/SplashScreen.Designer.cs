namespace Library_Manager_UI
{
    partial class SplashScreen
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
            this.splashDesign = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.pbHitLogo = new System.Windows.Forms.PictureBox();
            this.lblSplash = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pgbSplashLoad = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pbHitLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // splashDesign
            // 
            this.splashDesign.BorderRadius = 12;
            this.splashDesign.ContainerControl = this;
            this.splashDesign.DockIndicatorTransparencyValue = 0.6D;
            this.splashDesign.ResizeForm = false;
            this.splashDesign.TransparentWhileDrag = true;
            // 
            // pbHitLogo
            // 
            this.pbHitLogo.Image = global::Library_Manager_UI.Properties.Resources.HIT_logo_transparent;
            this.pbHitLogo.Location = new System.Drawing.Point(136, 70);
            this.pbHitLogo.Name = "pbHitLogo";
            this.pbHitLogo.Size = new System.Drawing.Size(129, 111);
            this.pbHitLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbHitLogo.TabIndex = 0;
            this.pbHitLogo.TabStop = false;
            // 
            // lblSplash
            // 
            this.lblSplash.BackColor = System.Drawing.Color.Transparent;
            this.lblSplash.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSplash.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(64)))), ((int)(((byte)(179)))));
            this.lblSplash.Location = new System.Drawing.Point(12, 12);
            this.lblSplash.Name = "lblSplash";
            this.lblSplash.Size = new System.Drawing.Size(154, 16);
            this.lblSplash.TabIndex = 1;
            this.lblSplash.Text = "Library Management System";
            // 
            // pgbSplashLoad
            // 
            this.pgbSplashLoad.BorderRadius = 5;
            this.pgbSplashLoad.FillColor = System.Drawing.Color.Transparent;
            this.pgbSplashLoad.Location = new System.Drawing.Point(-5, 242);
            this.pgbSplashLoad.Name = "pgbSplashLoad";
            this.pgbSplashLoad.ProgressColor = System.Drawing.Color.DodgerBlue;
            this.pgbSplashLoad.ProgressColor2 = System.Drawing.Color.DodgerBlue;
            this.pgbSplashLoad.Size = new System.Drawing.Size(407, 8);
            this.pgbSplashLoad.TabIndex = 2;
            this.pgbSplashLoad.Text = "guna2ProgressBar1";
            this.pgbSplashLoad.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.clock_Tick);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 250);
            this.Controls.Add(this.pgbSplashLoad);
            this.Controls.Add(this.lblSplash);
            this.Controls.Add(this.pbHitLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbHitLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm splashDesign;
        private System.Windows.Forms.PictureBox pbHitLogo;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblSplash;
        private Guna.UI2.WinForms.Guna2ProgressBar pgbSplashLoad;
        private System.Windows.Forms.Timer timer;
    }
}