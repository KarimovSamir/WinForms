using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompileExamV2
{
    public partial class CreateProjectForm : Form
    {
        public CreateOrOpenProjectForm CreateOrOpenProjectForm;
        public CreateProjectForm(CreateOrOpenProjectForm createOrOpenForm)
        {
            CreateOrOpenProjectForm = createOrOpenForm;
            InitializeComponent();
        }

        private void folderChooseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                CreateOrOpenProjectForm.Form1.folderPath = folderBrowserDialog1.SelectedPath;
                ProjectNameForm frm = new ProjectNameForm(this);
                this.Hide();
                frm.ShowDialog();
            }
            else
            {
                return;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
