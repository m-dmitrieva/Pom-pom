using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pom_Pom
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            filePathTextBox.Text = Program.settings.filePath;
            this.workTimeInput.Value = Program.settings.workTime;
            this.breakTimeInput.Value = Program.settings.breakTime;
            this.restTimeInput.Value = Program.settings.restTime;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            
        }

        
        //loads new filePath for projects file
        private void openFileDlgBtn_Click(object sender, EventArgs e)
        {
            chooseProjectFileDlg.FileName = this.filePathTextBox.Text;
            chooseProjectFileDlg.Filter = "Xml-files (*.xml)|*.xml|All files (*.*)|*.*";
            if (chooseProjectFileDlg.ShowDialog() == DialogResult.OK)
            {
                this.filePathTextBox.Text = chooseProjectFileDlg.FileName;

                Program.settings.filePath = chooseProjectFileDlg.FileName;
                Program.settings.filePathChaged = true;
                Program.settings.xmlTree = XmlProcessing.LoadProjectsFromFile(Program.settings.filePath);

            }
            
        }

        //
        private void OKBtn_Click(object sender, EventArgs e)
        {
            Program.settings.workTime = (int)this.workTimeInput.Value;
            Program.settings.breakTime = (int)this.breakTimeInput.Value;
            Program.settings.restTime = (int)this.restTimeInput.Value;

            if (!Program.settings.filePath.Equals(this.filePathTextBox.Text))
            {
                Program.settings.filePath = this.filePathTextBox.Text;
                Program.settings.xmlTree = XmlProcessing.LoadProjectsFromFile(Program.settings.filePath);
                Program.settings.filePathChaged = true;
                Program.settings.xmlTree = XmlProcessing.LoadProjectsFromFile(Program.settings.filePath);
            }
            


        }
    }
}
