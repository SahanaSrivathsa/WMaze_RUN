using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WMaze_RUN
{
    public partial class StartSplashScreen : Form
    {
        public StartSplashScreen()
        {
            InitializeComponent();
            this.timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadingBar.Increment(6);
            if (LoadingBar.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                new MainMenu().Show();
            }
        }
    }
}
