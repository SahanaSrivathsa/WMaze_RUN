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
    public partial class LinearTrackForm : Form
    {
        public LinearTrackForm()
        {
            InitializeComponent();
        }

        private void Cohort_CBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void BehaviourNotes_TxtBox_TextChanged(object sender, EventArgs e)
        {
            BehaviourNotes_TxtBox.Text = String.Empty;
        }

        private void SaveLT_Btn_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
