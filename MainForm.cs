using Pom_Pom.Properties;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Pom_Pom
{

    public partial class MainForm : Form
    {
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void myTimerStop()
        {
            Console.Beep();
            timerTimer.Stop();
            stopBtn.Enabled = false;
            startBtn.Enabled = true;

            stageLabel.Text = "";
            timerLabel.Text = "00:00";

            switch (state){
                case States.Work1:
                case States.Work2:
                case States.Work3:
                case States.Work4:
                    this.totalWorkPeriods++;
                    break;

                case States.Break1:
                case States.Break2:
                case States.Break3:
                    this.totalBreakPeriods++;
                    break;
                case States.Rest:
                    this.totalRestPeriods++;
                    break;

            }

            //refresh day review
            workPeriodsValueLabel.Text = totalWorkPeriods.ToString();
            stoppenWorkPeriodsValueLabel.Text = stoppedWorkPeriods.ToString();
            breakPeriodsValueLabel.Text = totalBreakPeriods.ToString();
            restPeriodsValueLabel.Text = totalRestPeriods.ToString();


            // loading next state for timer
            int stateNumber = (int)state;
            if ( stateNumber == statesLength-1)
            {
                stateNumber = 0;
            }
            else
            {
                stateNumber++;
            }
            state = (States)stateNumber;
            
        }

        private void LoadTreeNodesFromSettings()
        {
            pomidorsFromList.BeginUpdate();
            pomidorsFromList.Nodes.Clear();

            if (!Program.settings.filePath.Equals(String.Empty))
            {
                foreach (Project curProject in Program.settings.projects)
                {
                    TreeNode projNode = new TreeNode(curProject.name);
                    foreach (Job curJob in curProject.jobs)
                    {
                        projNode.Nodes.Add(new TreeNode(curJob.name));
                    }
                    pomidorsFromList.Nodes.Add(projNode);
                }
            }

            pomidorsFromList.EndUpdate();
        }

        private void NameForm_Load(object sender, EventArgs e)
        {

            LoadTreeNodesFromSettings();
        }

        private void workOnItBtn_MouseClick(object sender, MouseEventArgs e)
        {
            MessageBox.Show("Заглушка");
            /*ToDo: Запускает отсчет для выбранной задачи и добавляет время работы по таймеру к этой задаче*/
        }

        private void addNodeBtn_Click(object sender, EventArgs e)
        {
            string newItemName = null;

            //add job node in selected project в TreeView
            if (InputBox.Show("Add job", "Please, enter job name", ref newItemName) == DialogResult.OK)
            {
                Job newJob = new Job(newItemName, 0);
                Program.settings.projects[this.selectedNode.Index].Add(newJob);
                this.pomidorsFromList.Nodes[this.selectedNode.Index].Nodes.Add(new TreeNode(newItemName));
            }

            

        }

        private void deleteNodeBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete job " + this.selectedNode.Text+"?", 
                                    "Are you sure?", 
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.settings.projects[this.selectedNode.Parent.Index].jobs.RemoveAt(this.selectedNode.Index);
                this.pomidorsFromList.Nodes[this.selectedNode.Parent.Index].Nodes.RemoveAt(this.selectedNode.Index);
            }
        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            string newItemName = null;
            //add new project
            if (InputBox.Show("Add project", "Please, enter project name", ref newItemName) == DialogResult.OK)
            {
                Project newProject = new Project(newItemName);
                Program.settings.projects.Add(newProject);
                this.pomidorsFromList.Nodes.Add(new TreeNode(newItemName));
            }
        }

        private void deleteProjectBtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Delete project " + this.selectedNode.Text + "?", 
                                    "Are you sure?", 
                                    MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Program.settings.projects.RemoveAt(this.selectedNode.Index);
                this.pomidorsFromList.Nodes.RemoveAt(this.selectedNode.Index);
            }
        }

        private void timerTimer_Tick(object sender, EventArgs e)
        {
            if (timeToStop.CompareTo(DateTime.Now) <=0 )
            {
                this.myTimerStop();
            }
            else
            {
                TimeSpan diff = timeToStop - DateTime.Now;
                timerLabel.Text = String.Format("{0,2:D2}:{1,2:D2}", diff.Minutes, diff.Seconds);
            }
            
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now;
            //depending on the state set time interval
            switch (this.state)
            {
                case States.Work1:
                case States.Work2:
                case States.Work3:
                case States.Work4:
                    timeToStop = currentTime.AddMinutes(Program.settings.workTime);
                    stageLabel.Text = "Time to work!";
                    break;
                case States.Break1:
                case States.Break2:
                case States.Break3:
                    timeToStop = currentTime.AddMinutes(Program.settings.breakTime);
                    stageLabel.Text = "Take a break!";
                    break;
                case States.Rest:
                    timeToStop = currentTime.AddMinutes(Program.settings.restTime);
                    stageLabel.Text = "Give youself a rest";
                    break;
            }
            Console.Beep();
            timerTimer.Start();
            stopBtn.Enabled = true;
            startBtn.Enabled = false;

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            switch (state)
            {
                case States.Work1:
                case States.Work2:
                case States.Work3:
                case States.Work4:
                    this.stoppedWorkPeriods++;
                    break;
            }
            this.myTimerStop();
        }


        //Shows Settings Form
        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                if (Program.settings.filePathChaged)
                {
                    LoadTreeNodesFromSettings();
                    Program.settings.filePathChaged = false;
                }
                
            }
        }

        private void pomidorsFromList_AfterSelect(object sender, TreeViewEventArgs e)
        {
            bool isProject = (e.Node.Parent == null);
            
            int nodeIndex = e.Node.Index;
            //save link to selected node
            this.selectedNode = e.Node;

            //choosen project
            if (isProject)
            {
                //set availible
                addProjectBtn.Enabled = true;
                addJobBtn.Enabled = true;
                deleteProjectBtn.Enabled = true;

                //set unavailible buttons
                deleteJobBtn.Enabled = false;
                workOnItBtn.Enabled = false;

                //set values for "Project/Job review"
                jobReviewGroupBox.Text = "Project review";

                projectNameLabel.Visible = true;
                projectNameValueLabel.Visible = true;
                projectNameValueLabel.Text = e.Node.Text;

                jobNameLabel.Visible = false;
                jobNameValueLabel.Visible = false;

                pomodorosLabel.Visible = true;
                pomodorosValueLabel.Text = Program.settings.projects[nodeIndex].totalPoms.ToString();
                pomodorosValueLabel.Visible = true;

            }
            //choosen job
            else {
                //set availible/unavailible buttons
                addJobBtn.Enabled = false;
                deleteJobBtn.Enabled = true;
                workOnItBtn.Enabled = true;

                //set unavailible buttons
                addProjectBtn.Enabled = false;
                deleteProjectBtn.Enabled = false;

                //set values for "Job review"
                jobReviewGroupBox.Text = "Job review";

                projectNameLabel.Visible = true;
                projectNameValueLabel.Visible = true;
                projectNameValueLabel.Text = e.Node.Parent.Text;

                jobNameLabel.Visible = true;
                jobNameValueLabel.Visible = true;
                jobNameValueLabel.Text = e.Node.Text;

                pomodorosLabel.Visible = true;
                pomodorosValueLabel.Text = Program.settings.projects[e.Node.Parent.Index].jobs[nodeIndex].poms.ToString();
                pomodorosValueLabel.Visible = true;

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            //ToDo: добавить обработку ошибок. Начать здесь
            XmlProcessing.SaveProjectsToFile(Program.settings.filePath);
            MessageBox.Show("Data saved to "+ Program.settings.filePath);
        }
    }
}
