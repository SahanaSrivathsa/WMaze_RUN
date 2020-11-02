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
        #region ========== TOP LEVEL VARS ==========

        // Background Worker
        private static BackgroundWorker bw_arduino = new BackgroundWorker();

        //Serial Port

        private static readonly SerialPort serialPort = new SerialPort();

        public string fillMode;
        bool isConnectedArduino = false;

        #endregion

        #region ========== ARDUINO WORKER AND CLASSES ==========
        public FillFeedersForm()
        {
            // Serial Port Properties Initialize
            serialPort.BaudRate = 9600;
            serialPort.PortName = "COM3";
            serialPort.ReadTimeout = 10000;
            serialPort.Encoding = Encoding.UTF8;
            serialPort.DiscardNull = true;
            serialPort.WriteBufferSize = 10000;
            serialPort.Open();

            serialPort.DiscardInBuffer();
            serialPort.DiscardOutBuffer();

            // Send Arduino message for FILL FEEDER MODE
            try { serialPort.Write(new[] { 'F' }, 0, 1);}
            catch (Exception) {; }



            //Initialize
            InitializeComponent();
            bw_arduino.DoWork += listen_to_arduino;
        }

        // The listener mediates between the background worker and the updater
        public void listen_to_arduino(object sender, DoWorkEventArgs e)

        {
            try
            {
                var changedData = serialPort.ReadExisting();
                e.Result = changedData;
            }
            catch (Exception)
            {
            }
        }

        //Sending messages to ARDUINO for filling/cleaning amount changed. 
        public static void sendMessage(string button) //handles messages to be sent to the UNO for filling/cleaning
        {
            switch (button)
            {
                case "1":
                    try
                    {
                        serialPort.Write(new[] { 'X' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "2":
                    try
                    {
                        serialPort.Write(new[] { 'Y' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "3":
                    try
                    {
                        serialPort.Write(new[] { 'Z' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "4":
                    try
                    {
                        serialPort.Write(new[] { 'W' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "11":
                    try
                    {
                        serialPort.Write(new[] { 'x' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "22":
                    try
                    {
                        serialPort.Write(new[] { 'y' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "33":
                    try
                    {
                        serialPort.Write(new[] { 'z' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "44":
                    try
                    {
                        serialPort.Write(new[] { 'w' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "R1":
                    try
                    {
                        serialPort.Write(new[] { 'A' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "R2":
                    try
                    {
                        serialPort.Write(new[] { 'B' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "R3":
                    try
                    {
                        serialPort.Write(new[] { 'C' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;
                case "R4":
                    try
                    {
                        serialPort.Write(new[] { 'D' }, 0, 1);
                    }
                    catch (Exception)
                    {
                        ;
                    }
                    break;


            }
        }
        #endregion

        #region ========== BUTTON INITIAL STATES ==========
        private void CntArduino_Click(object sender, EventArgs e)
        {
            if (!isConnectedArduino)
            {
                //connectToArduino();
            }
            else
            {
                //disconnectFromArduino();
            }

        }



        private void FeederReturn_Btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Fill_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            fillMode = "FILL";
            //turn off testing mode in arduino
            try { serialPort.Write(new[] { 'r' }, 0, 1); }
            catch (Exception) {; }

        }

        private void TestAmt_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            fillMode = "TEST";
            //turn on testing mode in arduino
            try { serialPort.Write(new[] { 'R' }, 0, 1); }
            catch (Exception) {; }


        }

        private void ChangeAmt_RBtn_CheckedChanged(object sender, EventArgs e)
        {
            if (ChangeAmt_RBtn.Checked == true)
            {
                fillMode = "CHANGE";
                //turn of testing mode in arduino
                try { serialPort.Write(new[] { 'r' }, 0, 1); }
                catch (Exception) {; }

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
                    FillFeedersForm.sendMessage("1");
                    label2.Text = serialPort.ReadExisting();

                    break;
                case "TEST":
                    FillFeedersForm.sendMessage("R1");
                    label2.Text = serialPort.ReadExisting();
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
                    FillFeedersForm.sendMessage("2");
                    
                    break;
                case "TEST":
                    FillFeedersForm.sendMessage("R2");
                    label2.Text = serialPort.ReadExisting();
                    label2.Text = e.ToString();
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
                    FillFeedersForm.sendMessage("3");
                    break;
                case "TEST":
                    FillFeedersForm.sendMessage("R3");
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
                    FillFeedersForm.sendMessage("4");
                    break;
                case "TEST":
                    FillFeedersForm.sendMessage("R4");
                    break;
                case "CHANGE":
                    break;
            }
        }

        private void F1_StopBtn_Click(object sender, EventArgs e)
        {
            F1_StopBtn.Hide();
            FillFeedersForm.sendMessage("11");
        }

        private void F2_StopBtn_Click(object sender, EventArgs e)
        {
            F2_StopBtn.Hide();
            FillFeedersForm.sendMessage("22");
        }

        private void F3_StopBtn_Click(object sender, EventArgs e)
        {
            F3_StopBtn.Hide();
            FillFeedersForm.sendMessage("33");
        }

        private void F4_StopBtn_Click(object sender, EventArgs e)
        {
            F4_StopBtn.Hide();
            FillFeedersForm.sendMessage("44");
        }

        #endregion
    }
}
