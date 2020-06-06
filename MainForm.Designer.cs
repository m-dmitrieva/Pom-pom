namespace Pom_Pom
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.splitForPannels = new System.Windows.Forms.SplitContainer();
            this.stageLabel = new System.Windows.Forms.Label();
            this.stopBtn = new System.Windows.Forms.Button();
            this.startBtn = new System.Windows.Forms.Button();
            this.timerLabel = new System.Windows.Forms.Label();
            this.settingsButton = new System.Windows.Forms.Button();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.deleteProjectBtn = new System.Windows.Forms.Button();
            this.addProjectBtn = new System.Windows.Forms.Button();
            this.workOnItBtn = new System.Windows.Forms.Button();
            this.deleteNodeBtn = new System.Windows.Forms.Button();
            this.addNodeBtn = new System.Windows.Forms.Button();
            this.pomidorsFromList = new System.Windows.Forms.TreeView();
            this.timerTimer = new System.Windows.Forms.Timer(this.components);
            this.dayReviewGroupBox = new System.Windows.Forms.GroupBox();
            this.totalWorkLabel = new System.Windows.Forms.Label();
            this.stoppedWorkPeriodsLabel = new System.Windows.Forms.Label();
            this.BreakPeriodsLabel = new System.Windows.Forms.Label();
            this.RestPeriodsLabel = new System.Windows.Forms.Label();
            this.workPeriodsValueLabel = new System.Windows.Forms.Label();
            this.stoppenWorkPeriodsValueLabel = new System.Windows.Forms.Label();
            this.breakPeriodsValueLabel = new System.Windows.Forms.Label();
            this.restPeriodsValueLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitForPannels)).BeginInit();
            this.splitForPannels.Panel1.SuspendLayout();
            this.splitForPannels.Panel2.SuspendLayout();
            this.splitForPannels.SuspendLayout();
            this.buttonsPanel.SuspendLayout();
            this.dayReviewGroupBox.SuspendLayout();
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
            this.splitForPannels.Panel1.Controls.Add(this.dayReviewGroupBox);
            this.splitForPannels.Panel1.Controls.Add(this.stageLabel);
            this.splitForPannels.Panel1.Controls.Add(this.stopBtn);
            this.splitForPannels.Panel1.Controls.Add(this.startBtn);
            this.splitForPannels.Panel1.Controls.Add(this.timerLabel);
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
            // stageLabel
            // 
            this.stageLabel.AutoSize = true;
            this.stageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stageLabel.Location = new System.Drawing.Point(58, 53);
            this.stageLabel.Name = "stageLabel";
            this.stageLabel.Size = new System.Drawing.Size(90, 17);
            this.stageLabel.TabIndex = 4;
            this.stageLabel.Text = "Time to start!";
            // 
            // stopBtn
            // 
            this.stopBtn.Enabled = false;
            this.stopBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stopBtn.Location = new System.Drawing.Point(112, 170);
            this.stopBtn.Name = "stopBtn";
            this.stopBtn.Size = new System.Drawing.Size(94, 23);
            this.stopBtn.TabIndex = 3;
            this.stopBtn.Text = "Stop";
            this.stopBtn.UseVisualStyleBackColor = true;
            this.stopBtn.Click += new System.EventHandler(this.stopBtn_Click);
            // 
            // startBtn
            // 
            this.startBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startBtn.Location = new System.Drawing.Point(3, 170);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(95, 23);
            this.startBtn.TabIndex = 2;
            this.startBtn.Text = "Start";
            this.startBtn.UseVisualStyleBackColor = true;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // timerLabel
            // 
            this.timerLabel.AutoSize = true;
            this.timerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timerLabel.Location = new System.Drawing.Point(12, 83);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(194, 73);
            this.timerLabel.TabIndex = 1;
            this.timerLabel.Text = "00:00";
            // 
            // settingsButton
            // 
            this.settingsButton.Image = global::Pom_Pom.Properties.Resources.settings1;
            this.settingsButton.Location = new System.Drawing.Point(4, 4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(35, 35);
            this.settingsButton.TabIndex = 0;
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
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
            // timerTimer
            // 
            this.timerTimer.Interval = 1000;
            this.timerTimer.Tick += new System.EventHandler(this.timerTimer_Tick);
            // 
            // dayReviewGroupBox
            // 
            this.dayReviewGroupBox.Controls.Add(this.restPeriodsValueLabel);
            this.dayReviewGroupBox.Controls.Add(this.breakPeriodsValueLabel);
            this.dayReviewGroupBox.Controls.Add(this.stoppenWorkPeriodsValueLabel);
            this.dayReviewGroupBox.Controls.Add(this.workPeriodsValueLabel);
            this.dayReviewGroupBox.Controls.Add(this.RestPeriodsLabel);
            this.dayReviewGroupBox.Controls.Add(this.BreakPeriodsLabel);
            this.dayReviewGroupBox.Controls.Add(this.stoppedWorkPeriodsLabel);
            this.dayReviewGroupBox.Controls.Add(this.totalWorkLabel);
            this.dayReviewGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dayReviewGroupBox.Location = new System.Drawing.Point(4, 199);
            this.dayReviewGroupBox.Name = "dayReviewGroupBox";
            this.dayReviewGroupBox.Size = new System.Drawing.Size(200, 147);
            this.dayReviewGroupBox.TabIndex = 5;
            this.dayReviewGroupBox.TabStop = false;
            this.dayReviewGroupBox.Text = "Day review";
            // 
            // totalWorkLabel
            // 
            this.totalWorkLabel.AutoSize = true;
            this.totalWorkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.totalWorkLabel.Location = new System.Drawing.Point(7, 30);
            this.totalWorkLabel.Name = "totalWorkLabel";
            this.totalWorkLabel.Size = new System.Drawing.Size(79, 15);
            this.totalWorkLabel.TabIndex = 0;
            this.totalWorkLabel.Text = "Work periods";
            // 
            // stoppedWorkPeriodsLabel
            // 
            this.stoppedWorkPeriodsLabel.AutoSize = true;
            this.stoppedWorkPeriodsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stoppedWorkPeriodsLabel.Location = new System.Drawing.Point(7, 56);
            this.stoppedWorkPeriodsLabel.Name = "stoppedWorkPeriodsLabel";
            this.stoppedWorkPeriodsLabel.Size = new System.Drawing.Size(82, 15);
            this.stoppedWorkPeriodsLabel.TabIndex = 1;
            this.stoppedWorkPeriodsLabel.Text = "Stopped work";
            // 
            // BreakPeriodsLabel
            // 
            this.BreakPeriodsLabel.AutoSize = true;
            this.BreakPeriodsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BreakPeriodsLabel.Location = new System.Drawing.Point(7, 83);
            this.BreakPeriodsLabel.Name = "BreakPeriodsLabel";
            this.BreakPeriodsLabel.Size = new System.Drawing.Size(83, 15);
            this.BreakPeriodsLabel.TabIndex = 2;
            this.BreakPeriodsLabel.Text = "Break periods";
            // 
            // RestPeriodsLabel
            // 
            this.RestPeriodsLabel.AutoSize = true;
            this.RestPeriodsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RestPeriodsLabel.Location = new System.Drawing.Point(7, 110);
            this.RestPeriodsLabel.Name = "RestPeriodsLabel";
            this.RestPeriodsLabel.Size = new System.Drawing.Size(76, 15);
            this.RestPeriodsLabel.TabIndex = 3;
            this.RestPeriodsLabel.Text = "Rest periods";
            // 
            // workPeriodsValueLabel
            // 
            this.workPeriodsValueLabel.AutoSize = true;
            this.workPeriodsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.workPeriodsValueLabel.Location = new System.Drawing.Point(130, 30);
            this.workPeriodsValueLabel.Name = "workPeriodsValueLabel";
            this.workPeriodsValueLabel.Size = new System.Drawing.Size(14, 15);
            this.workPeriodsValueLabel.TabIndex = 4;
            this.workPeriodsValueLabel.Text = "0";
            // 
            // stoppenWorkPeriodsValueLabel
            // 
            this.stoppenWorkPeriodsValueLabel.AutoSize = true;
            this.stoppenWorkPeriodsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.stoppenWorkPeriodsValueLabel.Location = new System.Drawing.Point(130, 56);
            this.stoppenWorkPeriodsValueLabel.Name = "stoppenWorkPeriodsValueLabel";
            this.stoppenWorkPeriodsValueLabel.Size = new System.Drawing.Size(14, 15);
            this.stoppenWorkPeriodsValueLabel.TabIndex = 5;
            this.stoppenWorkPeriodsValueLabel.Text = "0";
            // 
            // breakPeriodsValueLabel
            // 
            this.breakPeriodsValueLabel.AutoSize = true;
            this.breakPeriodsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.breakPeriodsValueLabel.Location = new System.Drawing.Point(130, 83);
            this.breakPeriodsValueLabel.Name = "breakPeriodsValueLabel";
            this.breakPeriodsValueLabel.Size = new System.Drawing.Size(14, 15);
            this.breakPeriodsValueLabel.TabIndex = 6;
            this.breakPeriodsValueLabel.Text = "0";
            // 
            // restPeriodsValueLabel
            // 
            this.restPeriodsValueLabel.AutoSize = true;
            this.restPeriodsValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restPeriodsValueLabel.Location = new System.Drawing.Point(130, 110);
            this.restPeriodsValueLabel.Name = "restPeriodsValueLabel";
            this.restPeriodsValueLabel.Size = new System.Drawing.Size(14, 15);
            this.restPeriodsValueLabel.TabIndex = 7;
            this.restPeriodsValueLabel.Text = "0";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 450);
            this.Controls.Add(this.splitForPannels);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Pom-Pom";
            this.Load += new System.EventHandler(this.NameForm_Load);
            this.splitForPannels.Panel1.ResumeLayout(false);
            this.splitForPannels.Panel1.PerformLayout();
            this.splitForPannels.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitForPannels)).EndInit();
            this.splitForPannels.ResumeLayout(false);
            this.buttonsPanel.ResumeLayout(false);
            this.dayReviewGroupBox.ResumeLayout(false);
            this.dayReviewGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitForPannels;
        private System.Windows.Forms.TreeView pomidorsFromList;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Button addNodeBtn;
        private System.Windows.Forms.Button deleteNodeBtn;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button workOnItBtn;
        private System.Windows.Forms.Button deleteProjectBtn;
        private System.Windows.Forms.Button addProjectBtn;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Timer timerTimer;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.Button stopBtn;
        private System.Windows.Forms.Label stageLabel;
        private System.Windows.Forms.GroupBox dayReviewGroupBox;
        private System.Windows.Forms.Label totalWorkLabel;
        private System.Windows.Forms.Label BreakPeriodsLabel;
        private System.Windows.Forms.Label stoppedWorkPeriodsLabel;
        private System.Windows.Forms.Label RestPeriodsLabel;
        private System.Windows.Forms.Label stoppenWorkPeriodsValueLabel;
        private System.Windows.Forms.Label workPeriodsValueLabel;
        private System.Windows.Forms.Label breakPeriodsValueLabel;
        private System.Windows.Forms.Label restPeriodsValueLabel;
    }
}

