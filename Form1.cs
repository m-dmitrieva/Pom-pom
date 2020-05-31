using System;
using System.Windows.Forms;

namespace Pom_Pom
{

    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
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
    }
}
