using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;

namespace Pom_Pom
{
    public class XmlProcessing
    {
        public XmlProcessing()
        {
        }

        public static void LoadFromConfig()
        {
            string filePath = null;

            //loading application config file for some initial settings           
            try
            {
                XmlReader reader = XmlReader.Create("appConfig.xml");

                while (reader.Read())
                {
                    //read filePath to load previously saved tasks and jobs
                    //and break loop
                    if (reader.Name.Equals("tasksFilePath"))
                    {
                        filePath = reader.ReadElementContentAsString();
                        break;
                    }
                }

            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("appConfig.xml not found");
            }
            catch (XmlException ex)
            {
                Console.WriteLine("Something goes wrong with XML file. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something goes wrong. " + ex.Message);
            }

            //try to load tree of jobs from file
            if (!string.IsNullOrEmpty(filePath))
            {
                TreeNode parsedFile = LoadProjectsFromFile(filePath);
            }
        }
        
        /**
         * gets path to XML-file with pojects
         * returns parsed into TreeNode XML
         * */
        public static TreeNode LoadProjectsFromFile(string filePath)
        {
            TreeNode result = new TreeNode();
            try
            {
                XmlReader reader = XmlReader.Create(filePath);
                
                while (reader.Read())
                {

                }
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine(filePath +" not found");
            }
            catch (XmlException ex)
            {
                Console.WriteLine("Something goes wrong with XML file. " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Something goes wrong. " + ex.Message);
            }
            return result;

        }
    
    }
}