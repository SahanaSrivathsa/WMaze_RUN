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
    public partial class MainMenu : Form
    {
        private object SelectedExpWindow;
        public MainMenu()
        {
            InitializeComponent();
            

        }

        private void MainMenuSelectBtn_Click(object sender, EventArgs e)
        {
            switch (ExpModeListBox.SelectedItem.ToString())
            {
                case "Fill Feeders":
                    FillFeedersForm FFF = new FillFeedersForm();
                    FFF.ShowDialog();
                    break;

                case "Linear Track":
                    LinearTrackForm LTF = new LinearTrackForm();
                    LTF.ShowDialog();
                    break;

                    //case "W Maze":
                    //    WMazeForm WMF = new WMazeForm();
                    //    WMF.ShowDialog();
                    //    break;

                    //case "Tetrode Turning":
                    //    TetrodeTurningForm TTF = new TetrodeTurningForm();
                    //    TTF.ShowDialog();
                    //    break;

            }



        }
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.Equals((sender as Button).Name, @"CloseButton"))
            {
                Application.Exit();
            }
            // Do something proper to CloseButton.
            else
            {
                Application.Exit();
            }
        // Then assume that X has been clicked and act accordingly.
}
    }
}
