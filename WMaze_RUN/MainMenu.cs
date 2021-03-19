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
            switch (ExpMode_ListBox.SelectedItem.ToString())
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

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
