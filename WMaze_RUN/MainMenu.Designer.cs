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
            this.ExpModeListBox = new System.Windows.Forms.CheckedListBox();
            this.MainMenuSelectBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HeaderLabel
            // 
            this.HeaderLabel.AutoSize = true;
            this.HeaderLabel.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HeaderLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.HeaderLabel.Location = new System.Drawing.Point(12, 23);
            this.HeaderLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.HeaderLabel.Name = "HeaderLabel";
            this.HeaderLabel.Size = new System.Drawing.Size(288, 45);
            this.HeaderLabel.TabIndex = 0;
            this.HeaderLabel.Text = "Experiment Mode";
            // 
            // ExpModeListBox
            // 
            this.ExpModeListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ExpModeListBox.CheckOnClick = true;
            this.ExpModeListBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpModeListBox.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ExpModeListBox.FormattingEnabled = true;
            this.ExpModeListBox.Items.AddRange(new object[] {
            "Fill Feeders",
            "Linear Track",
            "W Maze",
            "Tetrode Turning"});
            this.ExpModeListBox.Location = new System.Drawing.Point(59, 94);
            this.ExpModeListBox.Name = "ExpModeListBox";
            this.ExpModeListBox.Size = new System.Drawing.Size(194, 136);
            this.ExpModeListBox.TabIndex = 1;
            // 
            // MainMenuSelectBtn
            // 
            this.MainMenuSelectBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.MainMenuSelectBtn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.MainMenuSelectBtn.Location = new System.Drawing.Point(87, 259);
            this.MainMenuSelectBtn.Name = "MainMenuSelectBtn";
            this.MainMenuSelectBtn.Size = new System.Drawing.Size(138, 51);
            this.MainMenuSelectBtn.TabIndex = 2;
            this.MainMenuSelectBtn.Text = "SELECT";
            this.MainMenuSelectBtn.UseVisualStyleBackColor = true;
            this.MainMenuSelectBtn.Click += new System.EventHandler(this.MainMenuSelectBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(312, 345);
            this.Controls.Add(this.MainMenuSelectBtn);
            this.Controls.Add(this.ExpModeListBox);
            this.Controls.Add(this.HeaderLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DimGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "MainMenu";
            this.Text = "5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HeaderLabel;
        private System.Windows.Forms.CheckedListBox ExpModeListBox;
        private System.Windows.Forms.Button MainMenuSelectBtn;
    }
}

