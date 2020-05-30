namespace Pom_Pom
{
    partial class NameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NameForm));
            this.splitForPannels = new System.Windows.Forms.SplitContainer();
            this.settingsButton = new System.Windows.Forms.Button();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.deleteProjectBtn = new System.Windows.Forms.Button();
            this.addProjectBtn = new System.Windows.Forms.Button();
            this.workOnItBtn = new System.Windows.Forms.Button();
            this.deleteNodeBtn = new System.Windows.Forms.Button();
            this.addNodeBtn = new System.Windows.Forms.Button();
            this.pomidorsFromList = new System.Windows.Forms.TreeView();
            this.pom_pomNotify = new System.Windows.Forms.NotifyIcon(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitForPannels)).BeginInit();
            this.splitForPannels.Panel1.SuspendLayout();
            this.splitForPannels.Panel2.SuspendLayout();
            this.splitForPannels.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitForPannels
            // 
            this.splitForPannels.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitForPannels.Location = new System.Drawing.Point(0, 0);
            this.splitForPannels.Name = "splitForPannels";
            // 
            // splitForPannels.Panel1
            // 
            this.splitForPannels.Panel1.Controls.Add(this.settingsButton);
            // 
            // splitForPannels.Panel2
            // 
            this.splitForPannels.Panel2.Controls.Add(this.buttonsPanel);
            this.splitForPannels.Panel2.Controls.Add(this.pomidorsFromList);
            this.splitForPannels.Size = new System.Drawing.Size(619, 450);
            this.splitForPannels.SplitterDistance = 211;
            this.splitForPannels.TabIndex = 0;
            // 
            // settingsButton
            // 
            this.settingsButton.Image = global::Pom_Pom.Properties.Resources.settings1;
            this.settingsButton.Location = new System.Drawing.Point(4, 4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(35, 35);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.UseVisualStyleBackColor = true;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.deleteProjectBtn);
            this.buttonsPanel.Controls.Add(this.addProjectBtn);
            this.buttonsPanel.Controls.Add(this.workOnItBtn);
            this.buttonsPanel.Controls.Add(this.deleteNodeBtn);
            this.buttonsPanel.Controls.Add(this.addNodeBtn);
            this.buttonsPanel.Location = new System.Drawing.Point(3, 379);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(398, 68);
            this.buttonsPanel.TabIndex = 1;
            // 
            // deleteProjectBtn
            // 
            this.deleteProjectBtn.Location = new System.Drawing.Point(230, 35);
            this.deleteProjectBtn.Name = "deleteProjectBtn";
            this.deleteProjectBtn.Size = new System.Drawing.Size(85, 29);
            this.deleteProjectBtn.TabIndex = 4;
            this.deleteProjectBtn.Text = "Delete Project";
            this.deleteProjectBtn.UseVisualStyleBackColor = true;
            this.deleteProjectBtn.Click += new System.EventHandler(this.deleteProjectBtn_Click);
            // 
            // addProjectBtn
            // 
            this.addProjectBtn.Location = new System.Drawing.Point(230, 3);
            this.addProjectBtn.Name = "addProjectBtn";
            this.addProjectBtn.Size = new System.Drawing.Size(85, 29);
            this.addProjectBtn.TabIndex = 3;
            this.addProjectBtn.Text = "Add Project";
            this.addProjectBtn.UseVisualStyleBackColor = true;
            this.addProjectBtn.Click += new System.EventHandler(this.addProjectBtn_Click);
            // 
            // workOnItBtn
            // 
            this.workOnItBtn.Location = new System.Drawing.Point(0, 4);
            this.workOnItBtn.Name = "workOnItBtn";
            this.workOnItBtn.Size = new System.Drawing.Size(75, 29);
            this.workOnItBtn.TabIndex = 2;
            this.workOnItBtn.Text = "Work on It";
            this.workOnItBtn.UseVisualStyleBackColor = true;
            this.workOnItBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.workOnItBtn_MouseClick);
            // 
            // deleteNodeBtn
            // 
            this.deleteNodeBtn.Location = new System.Drawing.Point(129, 35);
            this.deleteNodeBtn.Name = "deleteNodeBtn";
            this.deleteNodeBtn.Size = new System.Drawing.Size(85, 29);
            this.deleteNodeBtn.TabIndex = 1;
            this.deleteNodeBtn.Text = "Delete Task";
            this.deleteNodeBtn.UseVisualStyleBackColor = true;
            this.deleteNodeBtn.Click += new System.EventHandler(this.deleteNodeBtn_Click);
            // 
            // addNodeBtn
            // 
            this.addNodeBtn.Location = new System.Drawing.Point(129, 4);
            this.addNodeBtn.Name = "addNodeBtn";
            this.addNodeBtn.Size = new System.Drawing.Size(85, 29);
            this.addNodeBtn.TabIndex = 0;
            this.addNodeBtn.Text = "Add Task";
            this.addNodeBtn.UseVisualStyleBackColor = true;
            this.addNodeBtn.Click += new System.EventHandler(this.addNodeBtn_Click);
            // 
            // pomidorsFromList
            // 
            this.pomidorsFromList.Location = new System.Drawing.Point(3, 3);
            this.pomidorsFromList.Name = "pomidorsFromList";
            this.pomidorsFromList.Size = new System.Drawing.Size(398, 373);
            this.pomidorsFromList.TabIndex = 0;
            // 
            // pom_pomNotify
            // 
            this.pom_pomNotify.BalloonTipText = "Pom-Pom time manager";
            this.pom_pomNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("pom_pomNotify.Icon")));
            this.pom_pomNotify.Text = "pom_pom";
            this.pom_pomNotify.Visible = true;
            // 
            // NameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.splitForPannels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NameForm";
            this.Text = "Pom-Pom";
            this.Load += new System.EventHandler(this.NameForm_Load);
            this.splitForPannels.Panel1.ResumeLayout(false);
            this.splitForPannels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitForPannels)).EndInit();
            this.splitForPannels.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitForPannels;
        private System.Windows.Forms.NotifyIcon pom_pomNotify;
        private System.Windows.Forms.TreeView pomidorsFromList;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button addNodeBtn;
        private System.Windows.Forms.Button deleteNodeBtn;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button workOnItBtn;
        private System.Windows.Forms.Button deleteProjectBtn;
        private System.Windows.Forms.Button addProjectBtn;
    }
}

