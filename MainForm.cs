using System;
using System.Windows.Forms;

namespace Pom_Pom
{

    public partial class MainForm : Form
    {
        //values for working time, short break and long break
        //initialy loads from AppConfig file
        //by default values are 25, 5 and 20 minutes
        internal int workTime = 25;
        internal int shortBreak = 5;
        internal int rest = 20;

        private DateTime timeToStop = new DateTime();

        States state = States.Work1;

        public MainForm()
        {
            InitializeComponent();
        }

        private void myTimerStop()
        {
            Console.Beep();
            timerTimer.Stop();
            stageLabel.Text = "";
            timerLabel.Text = "00:00";
            stopBtn.Enabled = false;
        }

        private void NameForm_Load(object sender, EventArgs e)
        {
            //try to load jobs and tasks from previously setted file from config
            string filePath = XmlProcessing.LoadFromConfig();
            if (!filePath.Equals(String.Empty))
            {
                TreeNode NodesFromFile = XmlProcessing.LoadProjectsFromFile(filePath);
                for (int i =0; i < NodesFromFile.Nodes.Count; i++)
                {
                    this.pomidorsFromList.Nodes.Add(NodesFromFile.Nodes[i]);
                }
                
            }
            // load value for timer
            timerLabel.Text = "25:00";
            
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
                timerLabel.Text = diff.Minutes.ToString() + ":" + diff.Seconds.ToString();
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

        }

        private void stopBtn_Click(object sender, EventArgs e)
        {
            this.myTimerStop();
        }
    }
}
