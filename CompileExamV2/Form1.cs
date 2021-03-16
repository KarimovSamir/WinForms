using Microsoft.CSharp;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompileExamV2
{
    public partial class Form1 : Form
    {
        public string folderPath;
        public string exeFileName;
        public Form1()
        {
            InitializeComponent();        
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if (compilerTextBox.CanUndo == true)
            {
                compilerTextBox.Undo();
                compilerTextBox.ClearUndo();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (compilerTextBox.SelectedText != "")
            {
                compilerTextBox.Cut();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {  
            if (compilerTextBox.SelectionLength > 0)
            {
                compilerTextBox.Copy();
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text) == true)
            {
                if (compilerTextBox.SelectionLength > 0)
                {
                    if (MessageBox.Show("Do you want to paste over current selection?", "Cut", MessageBoxButtons.YesNo) == DialogResult.No)
                        compilerTextBox.SelectionStart = compilerTextBox.SelectionStart + compilerTextBox.SelectionLength;
                }
                compilerTextBox.Paste();
            }
        }

        private void copyAllTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (compilerTextBox.SelectionLength == 0)
            {
                compilerTextBox.SelectAll();
            }
            compilerTextBox.Copy();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            textStatus.Clear();
            CSharpCodeProvider csc = new CSharpCodeProvider(new Dictionary<string, string>() { { "CompilerVersion", "v4.0" } });
            CompilerParameters parameters = new CompilerParameters(new[] { "mscorlib.dll", "System.Core.dll" }, $"{exeFileName}.exe", true);
            parameters.GenerateExecutable = true;
            parameters.CompilerOptions = $"/out:" + folderPath + "/" + $"{exeFileName}.exe";
            CompilerResults results = csc.CompileAssemblyFromSource(parameters, compilerTextBox.Text);
            if (results.Errors.HasErrors)
            {
                results.Errors.Cast<CompilerError>().ToList().ForEach(error => textStatus.Text += error.ErrorText + "\r\n");
            }
            else
            {
                textStatus.Text = "----Build succeeded----";
                Process.Start(folderPath + "/" + $"{exeFileName}.exe");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CreateOrOpenProjectForm frm = new CreateOrOpenProjectForm(this);
            this.Hide();
            DialogResult result = frm.ShowDialog();

            TreeNode compilerNode = new TreeNode($"Solution '{exeFileName}'");
            solutionTreeView.Nodes.Add(compilerNode);
            TreeNode compilerNode2 = new TreeNode($"{exeFileName}");
            solutionTreeView.Nodes.Add(compilerNode2);
            solutionTreeView.Nodes[1].Nodes.Add(new TreeNode("Dependencies"));
            solutionTreeView.Nodes[1].Nodes.Add(new TreeNode("References"));
            if (File.Exists(folderPath + "/" + $"{exeFileName}.cs"))
            {
                compilerTextBox.Text = File.ReadAllText(folderPath + "/" + $"{exeFileName}.cs");
            }
            else
            {
                StreamWriter sr = new StreamWriter(folderPath + "/" + $"{exeFileName}.cs");
                sr.WriteLine(compilerTextBox.Text);
                sr.Close();
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sr = new StreamWriter(folderPath + "/" + $"{exeFileName}.cs");
            sr.WriteLine(compilerTextBox.Text);
            sr.Close();
        }
    }
}
