namespace Pom_Pom
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.projectFileGrBox = new System.Windows.Forms.GroupBox();
            this.openFileDlgBtn = new System.Windows.Forms.Button();
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.chooseProjectFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.timerGroupBox = new System.Windows.Forms.GroupBox();
            this.workTimeInput = new System.Windows.Forms.NumericUpDown();
            this.workTimeLabel = new System.Windows.Forms.Label();
            this.breakTimeLabel = new System.Windows.Forms.Label();
            this.breakTimeInput = new System.Windows.Forms.NumericUpDown();
            this.restTimeLabel = new System.Windows.Forms.Label();
            this.restTimeInput = new System.Windows.Forms.NumericUpDown();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            this.projectFileGrBox.SuspendLayout();
            this.timerGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workTimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakTimeInput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restTimeInput)).BeginInit();
            this.SuspendLayout();
            // 
            // projectFileGrBox
            // 
            this.projectFileGrBox.AutoSize = true;
            this.projectFileGrBox.Controls.Add(this.openFileDlgBtn);
            this.projectFileGrBox.Controls.Add(this.filePathTextBox);
            this.projectFileGrBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.projectFileGrBox.Location = new System.Drawing.Point(3, 3);
            this.projectFileGrBox.Name = "projectFileGrBox";
            this.projectFileGrBox.Size = new System.Drawing.Size(403, 62);
            this.projectFileGrBox.TabIndex = 0;
            this.projectFileGrBox.TabStop = false;
            this.projectFileGrBox.Text = "Project File loaded By default";
            // 
            // openFileDlgBtn
            // 
            this.openFileDlgBtn.Location = new System.Drawing.Point(321, 23);
            this.openFileDlgBtn.Name = "openFileDlgBtn";
            this.openFileDlgBtn.Size = new System.Drawing.Size(71, 20);
            this.openFileDlgBtn.TabIndex = 1;
            this.openFileDlgBtn.Text = "Set New";
            this.openFileDlgBtn.UseVisualStyleBackColor = true;
            this.openFileDlgBtn.Click += new System.EventHandler(this.openFileDlgBtn_Click);
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(11, 23);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(304, 20);
            this.filePathTextBox.TabIndex = 0;
            // 
            // chooseProjectFileDlg
            // 
            this.chooseProjectFileDlg.FileName = "openFileDialog1";
            // 
            // timerGroupBox
            // 
            this.timerGroupBox.Controls.Add(this.restTimeLabel);
            this.timerGroupBox.Controls.Add(this.restTimeInput);
            this.timerGroupBox.Controls.Add(this.breakTimeLabel);
            this.timerGroupBox.Controls.Add(this.breakTimeInput);
            this.timerGroupBox.Controls.Add(this.workTimeLabel);
            this.timerGroupBox.Controls.Add(this.workTimeInput);
            this.timerGroupBox.Location = new System.Drawing.Point(3, 71);
            this.timerGroupBox.Name = "timerGroupBox";
            this.timerGroupBox.Size = new System.Drawing.Size(403, 56);
            this.timerGroupBox.TabIndex = 1;
            this.timerGroupBox.TabStop = false;
            this.timerGroupBox.Text = "Timer settings";
            // 
            // workTimeInput
            // 
            this.workTimeInput.Location = new System.Drawing.Point(66, 21);
            this.workTimeInput.Name = "workTimeInput";
            this.workTimeInput.Size = new System.Drawing.Size(39, 20);
            this.workTimeInput.TabIndex = 0;
            // 
            // workTimeLabel
            // 
            this.workTimeLabel.AutoSize = true;
            this.workTimeLabel.Location = new System.Drawing.Point(5, 23);
            this.workTimeLabel.Name = "workTimeLabel";
            this.workTimeLabel.Size = new System.Drawing.Size(55, 13);
            this.workTimeLabel.TabIndex = 1;
            this.workTimeLabel.Text = "Work time";
            // 
            // breakTimeLabel
            // 
            this.breakTimeLabel.AutoSize = true;
            this.breakTimeLabel.Location = new System.Drawing.Point(140, 25);
            this.breakTimeLabel.Name = "breakTimeLabel";
            this.breakTimeLabel.Size = new System.Drawing.Size(57, 13);
            this.breakTimeLabel.TabIndex = 3;
            this.breakTimeLabel.Text = "Break time";
            // 
            // breakTimeInput
            // 
            this.breakTimeInput.Location = new System.Drawing.Point(203, 23);
            this.breakTimeInput.Name = "breakTimeInput";
            this.breakTimeInput.Size = new System.Drawing.Size(39, 20);
            this.breakTimeInput.TabIndex = 2;
            // 
            // restTimeLabel
            // 
            this.restTimeLabel.AutoSize = true;
            this.restTimeLabel.Location = new System.Drawing.Point(274, 27);
            this.restTimeLabel.Name = "restTimeLabel";
            this.restTimeLabel.Size = new System.Drawing.Size(51, 13);
            this.restTimeLabel.TabIndex = 5;
            this.restTimeLabel.Text = "Rest time";
            // 
            // restTimeInput
            // 
            this.restTimeInput.Location = new System.Drawing.Point(335, 25);
            this.restTimeInput.Name = "restTimeInput";
            this.restTimeInput.Size = new System.Drawing.Size(39, 20);
            this.restTimeInput.TabIndex = 4;
            // 
            // CancelBtn
            // 
            this.CancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelBtn.Location = new System.Drawing.Point(324, 370);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(71, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            // 
            // OKBtn
            // 
            this.OKBtn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKBtn.Location = new System.Drawing.Point(243, 370);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(75, 23);
            this.OKBtn.TabIndex = 3;
            this.OKBtn.Text = "OK";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 405);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.CancelBtn);
            this.Controls.Add(this.timerGroupBox);
            this.Controls.Add(this.projectFileGrBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.projectFileGrBox.ResumeLayout(false);
            this.projectFileGrBox.PerformLayout();
            this.timerGroupBox.ResumeLayout(false);
            this.timerGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workTimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.breakTimeInput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restTimeInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox projectFileGrBox;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button openFileDlgBtn;
        private System.Windows.Forms.OpenFileDialog chooseProjectFileDlg;
        private System.Windows.Forms.GroupBox timerGroupBox;
        private System.Windows.Forms.NumericUpDown workTimeInput;
        private System.Windows.Forms.Label breakTimeLabel;
        private System.Windows.Forms.NumericUpDown breakTimeInput;
        private System.Windows.Forms.Label workTimeLabel;
        private System.Windows.Forms.Label restTimeLabel;
        private System.Windows.Forms.NumericUpDown restTimeInput;
        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.Button OKBtn;
    }
}