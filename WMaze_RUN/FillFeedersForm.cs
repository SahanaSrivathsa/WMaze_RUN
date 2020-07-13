using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;



namespace WMaze_RUN
{
    public partial class FillFeedersForm : Form
    {
        public string fillMode;
        bool  isConnectedArduino = false;
        private static  SerialPort serialPort = new SerialPort();
        public BackgroundWorker felix = new BackgroundWorker();

        public FillFeedersForm()
        {
            InitializeComponent();
        }

        private void CntArduino_Click(object sender, EventArgs e)
        {
            if (!isConnectedArduino)
            {
                connectToArduino();
            }
            else
            {
                
            }

        }

        public void connectToArduino()
        {
            isConnectedArduino = true;
            serialPort = new SerialPort
            {
                BaudRate = 9600,
                PortName = "COM3",
                Encoding = Encoding.UTF8,
                DiscardNull = true,
                WriteBufferSize = 10000
            };
            serialPort.Open();
            serialPort.DiscardInBuffer();
            serialPort.DiscardOutBuffer();
            

        }

        private void FeederReturn_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Fill_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            fillMode = "FILL";
        }

        private void TestAmt_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            fillMode = "TEST";
        }

        private void ChangeAmt_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeAmt_RBtn.Checked == true)
            {
                fillMode = "CHANGE";
                FeederAmtTxtBox1.Show();
                FeederAmtTxtBox2.Show();
                FeederAmtTxtBox3.Show();
                FeederAmtTxtBox4.Show();

            }
            if (ChangeAmt_RBtn.Checked == false)
            {
                FeederAmtTxtBox1.Hide();
                FeederAmtTxtBox2.Hide();
                FeederAmtTxtBox3.Hide();
                FeederAmtTxtBox4.Hide();

            }

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
