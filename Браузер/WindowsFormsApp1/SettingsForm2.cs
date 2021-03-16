using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Browser
{
    public partial class SettingsForm2 : Form
    {
        public Form1 Form1;
        public SettingsForm2(Form1 form)
        {
            Form1 = form;
            InitializeComponent();
            searchSystemTextBox.Text = Form1.searchSystem;
            homeSettingsTextBox.Text = Form1.homePage;
            newTabUrlTextBox.Text = Form1.newTabUrl;            
        }

        private void saveFindSystembutton_Click(object sender, EventArgs e)
        {
            if (searchSystemTextBox.Text.Length != 0 && newTabUrlTextBox.Text.Contains("."))
            {
                Form1.searchSystem = searchSystemTextBox.Text;
            }
        }

        private void saveHomeButton_Click(object sender, EventArgs e)
        {
            if (homeSettingsTextBox.Text.Length != 0 && newTabUrlTextBox.Text.Contains("."))
            {
                Form1.homePage = homeSettingsTextBox.Text;
            }
        }

        private void newTabUrlButton_Click(object sender, EventArgs e)
        {
            if (newTabUrlTextBox.Text.Length != 0 && newTabUrlTextBox.Text.Contains("."))
            {
                Form1.newTabUrl = newTabUrlTextBox.Text;
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void deleteHistoryButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Form1.history.Clear();
        }
    }
}
