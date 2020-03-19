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

        private void F1_Btn_Click(object sender, EventArgs e)
        {
            switch (fillMode)
            {
                case "FILL":
                    F1_StopBtn.Show();
                    break;
                case "TEST":
                    break;
                case "CHANGE":
                    break;

            }
        }
        private void F2_btn_Click(object sender, EventArgs e)
        {
            switch (fillMode)
            {
                case "FILL":
                    F2_StopBtn.Show();
                    break;
                case "TEST":
                    break;
                case "CHANGE":
                    break;
            }
        }
        private void F3_Btn_Click(object sender, EventArgs e)
        {
            switch (fillMode)
            {
                case "FILL":
                    F3_StopBtn.Show();
                    break;
                case "TEST":
                    break;
                case "CHANGE":
                    break;
            }
        }

        private void F4_Btn_Click(object sender, EventArgs e)
        {
            switch (fillMode)
            {
                case "FILL":
                    F4_StopBtn.Show();
                    break;
                case "TEST":
                    break;
                case "CHANGE":
                    break;
            }
        }

        private void F1_StopBtn_Click(object sender, EventArgs e)
        {
            F1_StopBtn.Hide();
        }

        private void F2_StopBtn_Click(object sender, EventArgs e)
        {
            F2_StopBtn.Hide();
        }

        private void F3_StopBtn_Click(object sender, EventArgs e)
        {
            F3_StopBtn.Hide();
        }

        private void F4_StopBtn_Click(object sender, EventArgs e)
        {
            F4_StopBtn.Hide();
        }
    }
}
