using System;
using System.Drawing;
using System.Windows.Forms;

namespace WMaze_RUN
{
    partial class MainMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.HeaderLabel = new System.Windows.Forms.Label();
            this.MainMenuSelectBtn = new System.Windows.Forms.Button();
            this.ExpMode_ListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeaderLabel.Location = new System.Drawing.Point(13, 23);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(324, 45);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "EXPERIMENT MODE";
            // 
            // MainMenuSelectBtn
            // 
            this.MainMenuSelectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.MainMenuSelectBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainMenuSelectBtn.Location = new System.Drawing.Point(108, 329);
            this.MainMenuSelectBtn.Name = "MainMenuSelectBtn";
            this.MainMenuSelectBtn.Size = new System.Drawing.Size(138, 51);
            this.MainMenuSelectBtn.TabIndex = 2;
            this.MainMenuSelectBtn.Text = "SELECT";
            this.MainMenuSelectBtn.UseVisualStyleBackColor = true;
            this.MainMenuSelectBtn.Click += new System.EventHandler(this.MainMenuSelectBtn_Click);
            // 
            // ExpMode_ListBox
            // 
            this.ExpMode_ListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpMode_ListBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ExpMode_ListBox.Font = new System.Drawing.Font("Segoe UI Semibold", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpMode_ListBox.ForeColor = System.Drawing.SystemColors.GrayText;
            this.ExpMode_ListBox.FormattingEnabled = true;
            this.ExpMode_ListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ExpMode_ListBox.IntegralHeight = false;
            this.ExpMode_ListBox.ItemHeight = 44;
            this.ExpMode_ListBox.Items.AddRange(new object[] {
            "Fill Feeders",
            "Linear Track",
            "W Maze",
            "Tetrode Turn",
            "Table Update"});
            this.ExpMode_ListBox.Location = new System.Drawing.Point(46, 80);
            this.ExpMode_ListBox.Name = "ExpMode_ListBox";
            this.ExpMode_ListBox.Size = new System.Drawing.Size(266, 234);
            this.ExpMode_ListBox.TabIndex = 1;
            this.ExpMode_ListBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.DrawItemHandler);
            this.ExpMode_ListBox.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.MeasureItemHandler);
            this.ExpMode_ListBox.SelectedIndexChanged += new System.EventHandler(this.ExpMode_ListBox_SelectedIndexChanged_1);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(346, 392);
            this.Controls.Add(this.ExpMode_ListBox);
            this.Controls.Add(this.MainMenuSelectBtn);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void DrawItemHandler(object sender, DrawItemEventArgs e)
        {
            ListBox list = (ListBox)sender;
            if (e.Index > -1)
            {
                object item = list.Items[e.Index];
                e.DrawBackground();
                e.DrawFocusRectangle();
                Brush brush = new SolidBrush(e.ForeColor);
                SizeF size = e.Graphics.MeasureString(item.ToString(), e.Font);
                e.Graphics.DrawString(item.ToString(), e.Font, brush, e.Bounds.Left + (e.Bounds.Width / 2 - size.Width / 2), e.Bounds.Top + (e.Bounds.Height / 2 - size.Height / 2));
            }
        }

        private void MeasureItemHandler(object sender, System.Windows.Forms.MeasureItemEventArgs e)
        {
            e.ItemHeight =50;

        }
  

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.Button MainMenuSelectBtn;
        private System.Windows.Forms.ListBox ExpMode_ListBox;
        
    }
}

