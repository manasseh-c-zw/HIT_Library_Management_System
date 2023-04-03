using System;
using System.Windows.Forms;

namespace Library_Manager_UI
{
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            timer.Start();
        }


        //do your db conn and other things in here not puting a timer🤣🤣not nessesary
        private void clock_Tick(object sender, EventArgs e)
        {
            int increment = (int)Math.Max((pgbSplashLoad.Maximum - pgbSplashLoad.Minimum) / 100, 2);
            pgbSplashLoad.Value += increment;

            if (pgbSplashLoad.Value >= pgbSplashLoad.Maximum)
            {
                timer.Stop();


                this.Hide(); // hide the current form
                var login = new Login();
                login.Show(); // show the login form
            }
        }
    }
}
