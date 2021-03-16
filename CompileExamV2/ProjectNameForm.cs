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
    public partial class ProjectNameForm : Form
    {
        public CreateProjectForm CreateProjectForm;
        public ProjectNameForm(CreateProjectForm projectForm)
        {
            CreateProjectForm = projectForm;
            InitializeComponent();
        }

        private void startProjectButton_Click(object sender, EventArgs e)
        {
            CreateProjectForm.CreateOrOpenProjectForm.Form1.exeFileName = projectNameTextBox.Text;
            for (int i = Application.OpenForms.Count - 1; i >= 0; i--)
            {
                if (Application.OpenForms[i].Name != "Form1")
                {
                    Application.OpenForms[i].Close();
                }
            }
        }

        private void exitNameProjectButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
