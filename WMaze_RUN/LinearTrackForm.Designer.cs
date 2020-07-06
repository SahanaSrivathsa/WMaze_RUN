namespace WMaze_RUN
{
    partial class LinearTrackForm
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
            this.components = new System.ComponentModel.Container();
            this.RatDetails_GrpBox = new System.Windows.Forms.GroupBox();
            this.DateTimeValue_Label = new System.Windows.Forms.Label();
            this.Cheeta = new System.Windows.Forms.CheckBox();
            this.DateTime_Label = new System.Windows.Forms.Label();
            this.Exptr_TxtBox = new System.Windows.Forms.TextBox();
            this.Exptr_Label = new System.Windows.Forms.Label();
            this.RatHealth_TxtBox = new System.Windows.Forms.TextBox();
            this.RatHealth_Label = new System.Windows.Forms.Label();
            this.RatAge_Label = new System.Windows.Forms.Label();
            this.RatWeightPct_Label = new System.Windows.Forms.Label();
            this.RatWeight_TxtBox = new System.Windows.Forms.TextBox();
            this.RatWeight_label = new System.Windows.Forms.Label();
            this.RatNo_CBox = new System.Windows.Forms.ComboBox();
            this.RatNo_Label = new System.Windows.Forms.Label();
            this.Cohort_CBox = new System.Windows.Forms.ComboBox();
            this.CohortLabel = new System.Windows.Forms.Label();
            this.RecordingTime = new System.Windows.Forms.Timer(this.components);
            this.Timer_Label = new System.Windows.Forms.Label();
            this.LapsValue_Label = new System.Windows.Forms.Label();
            this.LapsPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Start_Btn = new System.Windows.Forms.Button();
            this.Stop_Btn = new System.Windows.Forms.Button();
            this.PreSleep_RBtn = new System.Windows.Forms.RadioButton();
            this.Task_RBtn = new System.Windows.Forms.RadioButton();
            this.PostSleep_RBtn = new System.Windows.Forms.RadioButton();
            this.Epochs_GrpBox = new System.Windows.Forms.GroupBox();
            this.SaveLT_Btn = new System.Windows.Forms.Button();
            this.BehaviourNotes_TxtBox = new System.Windows.Forms.TextBox();
            this.dataSet1 = new System.Data.DataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.RatDetails_GrpBox.SuspendLayout();
            this.LapsPanel.SuspendLayout();
            this.Epochs_GrpBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // RatDetails_GrpBox
            // 
            this.RatDetails_GrpBox.Controls.Add(this.DateTimeValue_Label);
            this.RatDetails_GrpBox.Controls.Add(this.Cheeta);
            this.RatDetails_GrpBox.Controls.Add(this.DateTime_Label);
            this.RatDetails_GrpBox.Controls.Add(this.Exptr_TxtBox);
            this.RatDetails_GrpBox.Controls.Add(this.Exptr_Label);
            this.RatDetails_GrpBox.Controls.Add(this.RatHealth_TxtBox);
            this.RatDetails_GrpBox.Controls.Add(this.RatHealth_Label);
            this.RatDetails_GrpBox.Controls.Add(this.RatAge_Label);
            this.RatDetails_GrpBox.Controls.Add(this.RatWeightPct_Label);
            this.RatDetails_GrpBox.Controls.Add(this.RatWeight_TxtBox);
            this.RatDetails_GrpBox.Controls.Add(this.RatWeight_label);
            this.RatDetails_GrpBox.Controls.Add(this.RatNo_CBox);
            this.RatDetails_GrpBox.Controls.Add(this.RatNo_Label);
            this.RatDetails_GrpBox.Controls.Add(this.Cohort_CBox);
            this.RatDetails_GrpBox.Controls.Add(this.CohortLabel);
            this.RatDetails_GrpBox.Location = new System.Drawing.Point(12, 12);
            this.RatDetails_GrpBox.Name = "RatDetails_GrpBox";
            this.RatDetails_GrpBox.Size = new System.Drawing.Size(448, 477);
            this.RatDetails_GrpBox.TabIndex = 1;
            this.RatDetails_GrpBox.TabStop = false;
            // 
            // DateTimeValue_Label
            // 
            this.DateTimeValue_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTimeValue_Label.Location = new System.Drawing.Point(111, 324);
            this.DateTimeValue_Label.Name = "DateTimeValue_Label";
            this.DateTimeValue_Label.Size = new System.Drawing.Size(310, 64);
            this.DateTimeValue_Label.TabIndex = 14;
            this.DateTimeValue_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cheeta
            // 
            this.Cheeta.Appearance = System.Windows.Forms.Appearance.Button;
            this.Cheeta.AutoSize = true;
            this.Cheeta.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cheeta.Location = new System.Drawing.Point(14, 406);
            this.Cheeta.Name = "Cheeta";
            this.Cheeta.Size = new System.Drawing.Size(407, 42);
            this.Cheeta.TabIndex = 13;
            this.Cheeta.Text = "ELECTROPHYSIOLOGY RECORDING";
            this.Cheeta.UseVisualStyleBackColor = true;
            // 
            // DateTime_Label
            // 
            this.DateTime_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTime_Label.Location = new System.Drawing.Point(6, 344);
            this.DateTime_Label.Name = "DateTime_Label";
            this.DateTime_Label.Size = new System.Drawing.Size(73, 25);
            this.DateTime_Label.TabIndex = 12;
            this.DateTime_Label.Text = "DATE:";
            this.DateTime_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Exptr_TxtBox
            // 
            this.Exptr_TxtBox.Location = new System.Drawing.Point(173, 278);
            this.Exptr_TxtBox.Name = "Exptr_TxtBox";
            this.Exptr_TxtBox.Size = new System.Drawing.Size(248, 33);
            this.Exptr_TxtBox.TabIndex = 11;
            // 
            // Exptr_Label
            // 
            this.Exptr_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exptr_Label.Location = new System.Drawing.Point(6, 282);
            this.Exptr_Label.Name = "Exptr_Label";
            this.Exptr_Label.Size = new System.Drawing.Size(161, 25);
            this.Exptr_Label.TabIndex = 10;
            this.Exptr_Label.Text = "EXPERIMENTER:";
            this.Exptr_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RatHealth_TxtBox
            // 
            this.RatHealth_TxtBox.Location = new System.Drawing.Point(116, 216);
            this.RatHealth_TxtBox.Name = "RatHealth_TxtBox";
            this.RatHealth_TxtBox.Size = new System.Drawing.Size(305, 33);
            this.RatHealth_TxtBox.TabIndex = 9;
            // 
            // RatHealth_Label
            // 
            this.RatHealth_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatHealth_Label.Location = new System.Drawing.Point(6, 220);
            this.RatHealth_Label.Name = "RatHealth_Label";
            this.RatHealth_Label.Size = new System.Drawing.Size(93, 25);
            this.RatHealth_Label.TabIndex = 8;
            this.RatHealth_Label.Text = "HEALTH:";
            this.RatHealth_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RatAge_Label
            // 
            this.RatAge_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatAge_Label.Location = new System.Drawing.Point(265, 96);
            this.RatAge_Label.Name = "RatAge_Label";
            this.RatAge_Label.Size = new System.Drawing.Size(109, 25);
            this.RatAge_Label.TabIndex = 7;
            this.RatAge_Label.Text = "AGE:";
            this.RatAge_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RatWeightPct_Label
            // 
            this.RatWeightPct_Label.Location = new System.Drawing.Point(265, 155);
            this.RatWeightPct_Label.Name = "RatWeightPct_Label";
            this.RatWeightPct_Label.Size = new System.Drawing.Size(109, 31);
            this.RatWeightPct_Label.TabIndex = 6;
            this.RatWeightPct_Label.Text = "%";
            this.RatWeightPct_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RatWeight_TxtBox
            // 
            this.RatWeight_TxtBox.Location = new System.Drawing.Point(116, 154);
            this.RatWeight_TxtBox.Name = "RatWeight_TxtBox";
            this.RatWeight_TxtBox.Size = new System.Drawing.Size(121, 33);
            this.RatWeight_TxtBox.TabIndex = 5;
            // 
            // RatWeight_label
            // 
            this.RatWeight_label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatWeight_label.Location = new System.Drawing.Point(6, 158);
            this.RatWeight_label.Name = "RatWeight_label";
            this.RatWeight_label.Size = new System.Drawing.Size(93, 25);
            this.RatWeight_label.TabIndex = 4;
            this.RatWeight_label.Text = "WEIGHT:";
            this.RatWeight_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RatNo_CBox
            // 
            this.RatNo_CBox.FormattingEnabled = true;
            this.RatNo_CBox.Location = new System.Drawing.Point(116, 92);
            this.RatNo_CBox.Name = "RatNo_CBox";
            this.RatNo_CBox.Size = new System.Drawing.Size(121, 33);
            this.RatNo_CBox.TabIndex = 3;
            // 
            // RatNo_Label
            // 
            this.RatNo_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RatNo_Label.Location = new System.Drawing.Point(6, 96);
            this.RatNo_Label.Name = "RatNo_Label";
            this.RatNo_Label.Size = new System.Drawing.Size(93, 25);
            this.RatNo_Label.TabIndex = 2;
            this.RatNo_Label.Text = "RAT NO:";
            this.RatNo_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Cohort_CBox
            // 
            this.Cohort_CBox.FormattingEnabled = true;
            this.Cohort_CBox.Location = new System.Drawing.Point(116, 28);
            this.Cohort_CBox.Name = "Cohort_CBox";
            this.Cohort_CBox.Size = new System.Drawing.Size(121, 33);
            this.Cohort_CBox.TabIndex = 1;
            this.Cohort_CBox.SelectedIndexChanged += new System.EventHandler(this.Cohort_CBox_SelectedIndexChanged);
            // 
            // CohortLabel
            // 
            this.CohortLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CohortLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CohortLabel.Location = new System.Drawing.Point(6, 29);
            this.CohortLabel.Name = "CohortLabel";
            this.CohortLabel.Size = new System.Drawing.Size(104, 30);
            this.CohortLabel.TabIndex = 0;
            this.CohortLabel.Text = "COHORT:";
            this.CohortLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Timer_Label
            // 
            this.Timer_Label.AutoSize = true;
            this.Timer_Label.Font = new System.Drawing.Font("Segoe UI", 56.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer_Label.Location = new System.Drawing.Point(604, 22);
            this.Timer_Label.Name = "Timer_Label";
            this.Timer_Label.Size = new System.Drawing.Size(234, 100);
            this.Timer_Label.TabIndex = 2;
            this.Timer_Label.Text = "00:00";
            // 
            // LapsValue_Label
            // 
            this.LapsValue_Label.AutoSize = true;
            this.LapsValue_Label.Font = new System.Drawing.Font("Segoe UI", 39.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LapsValue_Label.Location = new System.Drawing.Point(29, 40);
            this.LapsValue_Label.Name = "LapsValue_Label";
            this.LapsValue_Label.Size = new System.Drawing.Size(60, 71);
            this.LapsValue_Label.TabIndex = 3;
            this.LapsValue_Label.Text = "0";
            // 
            // LapsPanel
            // 
            this.LapsPanel.Controls.Add(this.label1);
            this.LapsPanel.Controls.Add(this.LapsValue_Label);
            this.LapsPanel.Location = new System.Drawing.Point(874, 12);
            this.LapsPanel.Name = "LapsPanel";
            this.LapsPanel.Size = new System.Drawing.Size(120, 124);
            this.LapsPanel.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "LAPS";
            // 
            // Start_Btn
            // 
            this.Start_Btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Start_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SeaGreen;
            this.Start_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SeaGreen;
            this.Start_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Start_Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start_Btn.Location = new System.Drawing.Point(489, 22);
            this.Start_Btn.Name = "Start_Btn";
            this.Start_Btn.Size = new System.Drawing.Size(87, 42);
            this.Start_Btn.TabIndex = 5;
            this.Start_Btn.Text = "START";
            this.Start_Btn.UseVisualStyleBackColor = false;
            // 
            // Stop_Btn
            // 
            this.Stop_Btn.BackColor = System.Drawing.Color.LightCoral;
            this.Stop_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Firebrick;
            this.Stop_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Firebrick;
            this.Stop_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stop_Btn.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stop_Btn.Location = new System.Drawing.Point(489, 91);
            this.Stop_Btn.Name = "Stop_Btn";
            this.Stop_Btn.Size = new System.Drawing.Size(87, 42);
            this.Stop_Btn.TabIndex = 6;
            this.Stop_Btn.Text = "STOP";
            this.Stop_Btn.UseVisualStyleBackColor = false;
            // 
            // PreSleep_RBtn
            // 
            this.PreSleep_RBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.PreSleep_RBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PreSleep_RBtn.Location = new System.Drawing.Point(0, 14);
            this.PreSleep_RBtn.Name = "PreSleep_RBtn";
            this.PreSleep_RBtn.Size = new System.Drawing.Size(124, 38);
            this.PreSleep_RBtn.TabIndex = 7;
            this.PreSleep_RBtn.TabStop = true;
            this.PreSleep_RBtn.Text = "PRE-SLEEP";
            this.PreSleep_RBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PreSleep_RBtn.UseVisualStyleBackColor = true;
            // 
            // Task_RBtn
            // 
            this.Task_RBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.Task_RBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task_RBtn.Location = new System.Drawing.Point(0, 74);
            this.Task_RBtn.Name = "Task_RBtn";
            this.Task_RBtn.Size = new System.Drawing.Size(124, 35);
            this.Task_RBtn.TabIndex = 8;
            this.Task_RBtn.TabStop = true;
            this.Task_RBtn.Text = "TASK";
            this.Task_RBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Task_RBtn.UseVisualStyleBackColor = true;
            // 
            // PostSleep_RBtn
            // 
            this.PostSleep_RBtn.Appearance = System.Windows.Forms.Appearance.Button;
            this.PostSleep_RBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PostSleep_RBtn.Location = new System.Drawing.Point(0, 131);
            this.PostSleep_RBtn.Name = "PostSleep_RBtn";
            this.PostSleep_RBtn.Size = new System.Drawing.Size(124, 35);
            this.PostSleep_RBtn.TabIndex = 9;
            this.PostSleep_RBtn.TabStop = true;
            this.PostSleep_RBtn.Text = "POST-SLEEP";
            this.PostSleep_RBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PostSleep_RBtn.UseVisualStyleBackColor = true;
            // 
            // Epochs_GrpBox
            // 
            this.Epochs_GrpBox.Controls.Add(this.PreSleep_RBtn);
            this.Epochs_GrpBox.Controls.Add(this.Task_RBtn);
            this.Epochs_GrpBox.Controls.Add(this.PostSleep_RBtn);
            this.Epochs_GrpBox.Location = new System.Drawing.Point(872, 137);
            this.Epochs_GrpBox.Name = "Epochs_GrpBox";
            this.Epochs_GrpBox.Size = new System.Drawing.Size(124, 166);
            this.Epochs_GrpBox.TabIndex = 10;
            this.Epochs_GrpBox.TabStop = false;
            // 
            // SaveLT_Btn
            // 
            this.SaveLT_Btn.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveLT_Btn.Location = new System.Drawing.Point(874, 403);
            this.SaveLT_Btn.Name = "SaveLT_Btn";
            this.SaveLT_Btn.Size = new System.Drawing.Size(124, 57);
            this.SaveLT_Btn.TabIndex = 11;
            this.SaveLT_Btn.Text = "SAVE";
            this.SaveLT_Btn.UseVisualStyleBackColor = true;
            this.SaveLT_Btn.Click += new System.EventHandler(this.SaveLT_Btn_Click);
            // 
            // BehaviourNotes_TxtBox
            // 
            this.BehaviourNotes_TxtBox.BackColor = System.Drawing.Color.White;
            this.BehaviourNotes_TxtBox.Location = new System.Drawing.Point(489, 168);
            this.BehaviourNotes_TxtBox.Multiline = true;
            this.BehaviourNotes_TxtBox.Name = "BehaviourNotes_TxtBox";
            this.BehaviourNotes_TxtBox.Size = new System.Drawing.Size(365, 126);
            this.BehaviourNotes_TxtBox.TabIndex = 12;
            this.BehaviourNotes_TxtBox.Text = "Behavioural Notes:";
            this.BehaviourNotes_TxtBox.TextChanged += new System.EventHandler(this.BehaviourNotes_TxtBox_TextChanged);
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(489, 320);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 13;
            // 
            // LinearTrackForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1008, 506);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.BehaviourNotes_TxtBox);
            this.Controls.Add(this.SaveLT_Btn);
            this.Controls.Add(this.Epochs_GrpBox);
            this.Controls.Add(this.Stop_Btn);
            this.Controls.Add(this.Start_Btn);
            this.Controls.Add(this.LapsPanel);
            this.Controls.Add(this.Timer_Label);
            this.Controls.Add(this.RatDetails_GrpBox);
            this.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "LinearTrackForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "LinearTrackForm";
            this.RatDetails_GrpBox.ResumeLayout(false);
            this.RatDetails_GrpBox.PerformLayout();
            this.LapsPanel.ResumeLayout(false);
            this.LapsPanel.PerformLayout();
            this.Epochs_GrpBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox RatDetails_GrpBox;
        private System.Windows.Forms.ComboBox Cohort_CBox;
        private System.Windows.Forms.Label CohortLabel;
        private System.Windows.Forms.Label RatNo_Label;
        private System.Windows.Forms.CheckBox Cheeta;
        private System.Windows.Forms.Label DateTime_Label;
        private System.Windows.Forms.TextBox Exptr_TxtBox;
        private System.Windows.Forms.Label Exptr_Label;
        private System.Windows.Forms.TextBox RatHealth_TxtBox;
        private System.Windows.Forms.Label RatHealth_Label;
        private System.Windows.Forms.Label RatAge_Label;
        private System.Windows.Forms.Label RatWeightPct_Label;
        private System.Windows.Forms.TextBox RatWeight_TxtBox;
        private System.Windows.Forms.Label RatWeight_label;
        private System.Windows.Forms.ComboBox RatNo_CBox;
        private System.Windows.Forms.Label DateTimeValue_Label;
        private System.Windows.Forms.Timer RecordingTime;
        private System.Windows.Forms.Label Timer_Label;
        private System.Windows.Forms.Label LapsValue_Label;
        private System.Windows.Forms.Panel LapsPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Start_Btn;
        private System.Windows.Forms.Button Stop_Btn;
        private System.Windows.Forms.RadioButton PreSleep_RBtn;
        private System.Windows.Forms.RadioButton Task_RBtn;
        private System.Windows.Forms.RadioButton PostSleep_RBtn;
        private System.Windows.Forms.GroupBox Epochs_GrpBox;
        private System.Windows.Forms.Button SaveLT_Btn;
        private System.Windows.Forms.TextBox BehaviourNotes_TxtBox;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}