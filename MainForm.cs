using Pom_Pom.Properties;
using System;
using System.Collections.Generic;
using System.Runtime;
using System.Windows.Forms;

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
                for (int i = 0; i < Program.settings.xmlTree.Nodes.Count; i++)
                {
                    this.pomidorsFromList.Nodes.Add(Program.settings.xmlTree.Nodes[i]);
                }
            }

            //ToDo: удалить после отладки
            Console.WriteLine("File reloaded");
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
            MessageBox.Show("Заглушка");
            /*ToDo: Реализовать добавление узла задачи в выделенный проект*/
        }

        private void deleteNodeBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заглушка");
            /*ToDo: реализовать удаление выбранного узла задачи*/
        }

        private void addProjectBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заглушка");
            /*ToDO: реализовать добавление проекта в дерево*/
        }

        private void deleteProjectBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Заглушка");
            /*ToDo: реализовать удаление узла проекта из дерева*/
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
            this.myTimerStop();
        }


        //Shows Settings Form
        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm settingsForm = new SettingsForm();
            if (settingsForm.ShowDialog() == DialogResult.OK)
            {
                //ToDo: удалить после отладки
                Console.WriteLine("Dialog Result OK");
                if (Program.settings.filePathChaged)
                {
                    LoadTreeNodesFromSettings();
                    Program.settings.filePathChaged = false;
                }
                
            }
            else
            {
                //there is nothing to change in main form
                Console.WriteLine("Dialog Result Cancel");
            }
        }
    }
}
