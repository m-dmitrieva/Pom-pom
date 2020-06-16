using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Collections.Generic;
using System.CodeDom.Compiler;

namespace Pom_Pom
{
    public class XmlProcessing
    {
        public XmlProcessing()
        {
        }
        /*
         *create dictionary of settings from appConfig.xml
         */
        public static Dictionary<string, string> LoadValuesFromConfig()
        {
            Dictionary<string, string> valuesFromConfig = new Dictionary<string, string>();

            //loading application config file for some initial settings           
            try
            {
                XmlReader reader = XmlReader.Create("appConfig.xml");

                while (reader.Read())
                {
                    //read filePath to load previously saved tasks and jobs
                    //and break loop
                    if (reader.Name.Equals("taskFilePath"))
                    {
                        valuesFromConfig.Add("filePath", reader.ReadElementContentAsString());
                        reader.ReadToNextSibling("timeIntervals");
                    }
                    if (reader.Name.Equals("timeIntervals"))
                    {
                        while (reader.Read() && !(reader.Name.Equals("timeIntervals") && reader.NodeType == XmlNodeType.EndElement))
                        {
                            if (reader.Name.Equals("work") && (reader.NodeType != XmlNodeType.EndElement))
                            {
                                valuesFromConfig.Add("work", reader.ReadElementContentAsString());
                            }
                            if (reader.Name.Equals("break") && (reader.NodeType != XmlNodeType.EndElement))
                            {
                                valuesFromConfig.Add("break", reader.ReadElementContentAsString());
                            }
                            if (reader.Name.Equals("rest") && (reader.NodeType != XmlNodeType.EndElement))
                            {
                                valuesFromConfig.Add("rest", reader.ReadElementContentAsString());
                            }
                        }
                    }
                }
                reader.Close();

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
            return valuesFromConfig;
        }
        
        /**
         * gets path to XML-file with pojects
         * returns parsed into TreeNode XML
         * */
        public static List<Project> LoadProjectsFromFile(string filePath)
        {
            TreeNode rootNode = new TreeNode();
            List<Project> projectsList = new List<Project>();
            try
            {
                XmlReader reader = XmlReader.Create(filePath);

                while (reader.Read())
                {
                    
                    if (reader.Name.Equals("projects") && (reader.NodeType != XmlNodeType.EndElement))
                    {
                        
                        while (reader.Read() && !(reader.Name.Equals("projects") && (reader.NodeType == XmlNodeType.EndElement)))
                        {
                            if (reader.Name.Equals("project") && (reader.NodeType != XmlNodeType.EndElement))
                            {
                                TreeNode projectNode = new TreeNode(reader.GetAttribute("name"));
                                rootNode.Nodes.Add(projectNode);

                                int totalPoms = 0;

                                Project project = new Project(projectNode.Text);
                                

                                while (reader.Read() && !(reader.Name.Equals("project") && (reader.NodeType == XmlNodeType.EndElement)) )
                                {
                                    if (reader.Name.Equals("job") && (reader.NodeType != XmlNodeType.EndElement))
                                    {
                                        int poms = 0;
                                        try
                                        {
                                            poms = int.Parse(reader.GetAttribute("poms"));
                                        }catch (Exception ex)
                                        {
                                            Console.WriteLine("Error parsing poms attribute. Message: " + ex.Message);
                                            poms = 0;
                                        }
                                        TreeNode jobNode = new TreeNode(reader.ReadElementContentAsString());
                                        projectNode.Nodes.Add(jobNode);

                                        Job job = new Job(jobNode.Text, poms);
                                        
                                        totalPoms += poms;
                                        project.Add(job);
                                    }
                                }
                                project.totalPoms = totalPoms;
                                projectsList.Add(project);
                                
                            }
                        }
                    }
                  
                }
                reader.Close();
                
                
            }
            catch (System.IO.FileNotFoundException)
            {
                Console.WriteLine("Exception in LoadProjectsFromFile.");
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
            return projectsList;
            //return rootNode;

        }
    
        public static void SaveConfigToFile()
        {
            XmlWriterSettings xmlWriterSetings = new XmlWriterSettings();
            xmlWriterSetings.Indent = true; // отступы  для элементов
            xmlWriterSetings.IndentChars = "\t";

            XmlWriter writer = XmlWriter.Create("appConfig.xml", xmlWriterSetings);

            //write header <?xml...>
            writer.WriteStartDocument(true);

            writer.WriteStartElement("settings");

            writer.WriteElementString("taskFilePath", Program.settings.filePath);

            writer.WriteStartElement("timeIntervals");
            writer.WriteElementString("work", Program.settings.workTime.ToString());
            writer.WriteElementString("break", Program.settings.breakTime.ToString());
            writer.WriteElementString("rest", Program.settings.restTime.ToString());


            writer.WriteFullEndElement();
            writer.WriteEndElement();
            //close writer to write content to the file and save changes
            writer.Close();

        }

        public static void SaveProjectsToFile(string filePath)
        {
            XmlWriterSettings xmlWriterSetings = new XmlWriterSettings();
            xmlWriterSetings.Indent = true; // отступы  для элементов
            xmlWriterSetings.IndentChars = "\t";

            XmlWriter writer = XmlWriter.Create(filePath, xmlWriterSetings);

            writer.WriteStartDocument(true);

            writer.WriteStartElement("projects");
            foreach (Project curProject in Program.settings.projects)
            {
                writer.WriteStartElement("project");
                writer.WriteAttributeString("name", curProject.name);
                foreach (Job curJob in curProject.jobs)
                {
                    writer.WriteStartElement("job");
                    writer.WriteAttributeString("poms", curJob.poms.ToString());
                    writer.WriteString(curJob.name);
                    writer.WriteEndElement();
                }

                writer.WriteEndElement();
            }
            

            //writer.WriteFullEndElement();
            writer.WriteEndElement();
            //close writer to write content to the file and save changes
            writer.Close();
        }
    }
}