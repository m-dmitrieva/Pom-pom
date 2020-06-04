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
        public SettingsForm(string filePath)
        {
            InitializeComponent();
            filePathTextBox.Text = filePath;
        }

        private void SettingsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            
        }

        private void openFileDlgBtn_Click(object sender, EventArgs e)
        {
            chooseProjectFileDlg.FileName = this.filePathTextBox.Text;
            chooseProjectFileDlg.Filter = "Xml-files (*.xml)|*.xml|All files (*.*)|*.*";
            if (chooseProjectFileDlg.ShowDialog() == DialogResult.OK)
            {
            //    this.filePathTextBox = chooseProjectFileDlg.FileName;
            }
            
        }
    }
}
