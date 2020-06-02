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

        private void NameForm_Load(object sender, EventArgs e)
        {
            Dictionary<string, string> valuesFromConfig = XmlProcessing.LoadFromConfig();

            //try to load jobs and tasks from previously setted file from config
            try
            {
                string filePath;
                valuesFromConfig.TryGetValue("filePath", out filePath);

                if (!filePath.Equals(String.Empty))
                {
                    TreeNode NodesFromFile = XmlProcessing.LoadProjectsFromFile(filePath);
                    for (int i = 0; i < NodesFromFile.Nodes.Count; i++)
                    {
                        this.pomidorsFromList.Nodes.Add(NodesFromFile.Nodes[i]);
                    }

                }
                
            }catch (ArgumentNullException ex)
            {
                Console.WriteLine("Exception Appears! There is no filePath loaded from config" + ex.Message);
            }
            try
            {
                //load values for timer
                string temp;
                valuesFromConfig.TryGetValue("work", out temp);

                this.workTime = Int32.Parse(temp);
                timerLabel.Text = String.Format("{0,2:D2}:00", workTime); ;

                valuesFromConfig.TryGetValue("break", out temp);
                this.shortBreak = Int32.Parse(temp);

                valuesFromConfig.TryGetValue("rest", out temp);
                this.rest = Int32.Parse(temp);
            }
            //catch exception from loading element from dictionary
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Loading time values crushed! " + ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Parse int from string failed! "+ex.Message);
            }
            // ToDo: вставить здесь обработку остальных ключей, извлеченных из appConfig
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
                    timeToStop = currentTime.AddMinutes(workTime);
                    stageLabel.Text = "Time to work!";
                    break;
                case States.Break1:
                case States.Break2:
                case States.Break3:
                    timeToStop = currentTime.AddMinutes(shortBreak);
                    stageLabel.Text = "Take a break!";
                    break;
                case States.Rest:
                    timeToStop = currentTime.AddMinutes(rest);
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
    }
}
