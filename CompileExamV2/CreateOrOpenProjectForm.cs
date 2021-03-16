using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompileExamV2
{
    public partial class CreateOrOpenProjectForm : Form
    {
        public string projectFolder;
        public Form1 Form1;
        public CreateOrOpenProjectForm(Form1 form)
        {
            Form1 = form;
            InitializeComponent();
        }

        private void openProjectButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog myFile = new OpenFileDialog();
            myFile.Title = "Compiler";
            myFile.Filter = "cs files (*.cs)|*.cs";
            //myFile.Filter = "cs files (*.cs)|*.cs|All files (*.*)|*.*";
            if (myFile.ShowDialog() == DialogResult.OK)
            {
                Form1.folderPath = Path.GetDirectoryName(myFile.FileName);
                Form1.exeFileName = Path.GetFileNameWithoutExtension(myFile.FileName);
                DialogResult = DialogResult.Cancel;
            }
            else
            {
                return;
            }
            Close();
        }

        private void exitFormCOOPButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void createProjectButton_Click(object sender, EventArgs e)
        {
            CreateProjectForm frm = new CreateProjectForm(this);
            this.Hide();
            frm.ShowDialog();
        }
    }
}
