﻿using System;
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

        public static string LoadFromConfig()
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
            return filePath;
        }
        
        /**
         * gets path to XML-file with pojects
         * returns parsed into TreeNode XML
         * */
        public static TreeNode LoadProjectsFromFile(string filePath)
        {
            TreeNode rootNode = new TreeNode();
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


                                while (reader.Read() && !(reader.Name.Equals("project") && (reader.NodeType == XmlNodeType.EndElement)) )
                                {
                                    if (reader.Name.Equals("job") && (reader.NodeType != XmlNodeType.EndElement))
                                    {
                                        TreeNode jobNode = new TreeNode(reader.GetAttribute("name"));
                                        projectNode.Nodes.Add(jobNode);
                                    }
                                }
                            }
                        }
                    }
                  
                }

                
                
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
            return rootNode;

        }
    
    }
}