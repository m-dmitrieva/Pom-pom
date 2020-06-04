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
            this.filePathTextBox = new System.Windows.Forms.TextBox();
            this.openFileDlgBtn = new System.Windows.Forms.Button();
            this.chooseProjectFileDlg = new System.Windows.Forms.OpenFileDialog();
            this.projectFileGrBox.SuspendLayout();
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
            this.projectFileGrBox.Size = new System.Drawing.Size(403, 70);
            this.projectFileGrBox.TabIndex = 0;
            this.projectFileGrBox.TabStop = false;
            this.projectFileGrBox.Text = "Project File";
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.Location = new System.Drawing.Point(11, 23);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.Size = new System.Drawing.Size(333, 20);
            this.filePathTextBox.TabIndex = 0;
            // 
            // openFileDlgBtn
            // 
            this.openFileDlgBtn.Location = new System.Drawing.Point(350, 23);
            this.openFileDlgBtn.Name = "openFileDlgBtn";
            this.openFileDlgBtn.Size = new System.Drawing.Size(24, 20);
            this.openFileDlgBtn.TabIndex = 1;
            this.openFileDlgBtn.Text = "...";
            this.openFileDlgBtn.UseVisualStyleBackColor = true;
            this.openFileDlgBtn.Click += new System.EventHandler(this.openFileDlgBtn_Click);
            // 
            // chooseProjectFileDlg
            // 
            this.chooseProjectFileDlg.FileName = "openFileDialog1";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 405);
            this.Controls.Add(this.projectFileGrBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SettingsForm_FormClosing);
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.projectFileGrBox.ResumeLayout(false);
            this.projectFileGrBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox projectFileGrBox;
        private System.Windows.Forms.TextBox filePathTextBox;
        private System.Windows.Forms.Button openFileDlgBtn;
        private System.Windows.Forms.OpenFileDialog chooseProjectFileDlg;
    }
}