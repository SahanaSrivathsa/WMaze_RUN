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
    public partial class FillFeedersForm : Form
    {
        public string fillMode;
        
        public FillFeedersForm()
        {
            InitializeComponent();
        }

        private void FeederReturn_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void F1_Btn_Click(object sender, EventArgs e)
        {
            switch (fillMode)
            {
                case "FILL":
                    
                    break
            }
        }

        private void FillBtn_Click(object sender, EventArgs e)
        {
            fillMode = "FILL";
        }

        private void ChkAmtBtn_Click(object sender, EventArgs e)
        {
            fillMode = "TEST";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fillMode = "CHANGE";
            FeederAmtTxtBox1.Show();
            FeederAmtTxtBox2.Show();
            FeederAmtTxtBox3.Show();
            FeederAmtTxtBox4.Show();

            
        }
    }
}
