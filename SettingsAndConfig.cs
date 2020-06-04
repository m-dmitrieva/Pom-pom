using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pom_Pom
{
    class SettingsAndConfig
    {
        internal int workTime { get; set; }
        internal int breakTime { get; set; }
        internal int restTime { get; set; }

        internal string filePath { get; set; } = null;

        internal TreeNode xmlTree = null;

        public SettingsAndConfig()
        {
            parseDictionary(XmlProcessing.LoadValuesFromConfig());
            xmlTree = XmlProcessing.LoadProjectsFromFile(filePath);
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
