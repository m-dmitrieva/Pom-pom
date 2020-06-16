using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pom_Pom
{
    public struct Job
    {
        public string name;
        public int poms;

        public Job(string name)
        {
            this.name = name;
            this.poms = 0;
        }
        public Job(string name, int poms)
        {
            this.name = name;
            this.poms = poms;
        }

    }

    public struct Project
    {
        public string name;
        public int totalPoms;
        public List<Job> jobs;

        public Project(string name)
        {
            this.name = name;
            this.totalPoms = 0;
            this.jobs = new List<Job>();
        }

        public void Add(Job job)
        {
            this.jobs.Add(job);
        }
    }
  
    class SettingsAndConfig
    {
        internal int workTime { get; set; }
        internal int breakTime { get; set; }
        internal int restTime { get; set; }

        internal string filePath { get; set; } = null;
        internal bool filePathChaged = false;

        public List<Project> projects = null;

        public SettingsAndConfig()
        {
            parseDictionary(XmlProcessing.LoadValuesFromConfig());
            LoadDataFromFile(filePath);
        }

        public void LoadDataFromFile(string filePath)
        {
            this.projects = XmlProcessing.LoadProjectsFromFile(filePath);
            //this.xmlTree = ProjectsToTree(this.projects);
        }

        private void parseDictionary(Dictionary<string, string> settings)
        {
            //load time values for timer
            try
            {
                string temp;

                settings.TryGetValue("work", out temp);
                this.workTime = Int32.Parse(temp);
                
                settings.TryGetValue("break", out temp);
                this.breakTime = Int32.Parse(temp);

                settings.TryGetValue("rest", out temp);
                this.restTime = Int32.Parse(temp);

                settings.TryGetValue("filePath", out temp);
                this.filePath = temp;
            }
            catch (Exception ex)
            {
                this.workTime = 25;
                this.breakTime = 5;
                this.restTime = 20;

                Console.WriteLine("Loading values from config crushed! " + ex.Message);
                Console.WriteLine("Setted default values!");
            }

        }

    }

}
