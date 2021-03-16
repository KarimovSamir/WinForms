using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Security.Policy;

namespace Browser
{
    public partial class Form1 : Form
    {
        public string searchSystem;
        public string homePage;
        public string newTabUrl;
        public List<string> favorite = new List<string>();
        public List<string> history = new List<string>();
        public Form1()
        {
            InitializeComponent();
            searchSystem = "google.com";
            homePage = "google.com";
            newTabUrl = "google.com";
        }

        private void leftButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                if (web.CanGoBack)
                {
                    web.GoBack();
                }
            }
        }

        private void rightButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;

            if (web != null)
            {
                if (web.CanGoForward)
                {
                    web.GoForward();
                }
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            web.Refresh();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            web.Navigate($"https://www.{homePage}");                
        }

        private void enterButton_Click(object sender, EventArgs e)
        {      
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (web != null)
            {
                web.Navigate(textBox1.Text);        
            }
        }
        WebBrowser webTab = null;
        private void addTabButton_Click(object sender, EventArgs e)
        {
            int numPagine;
            string strPagine;
            numPagine = tabControl1.TabCount;
            strPagine = numPagine.ToString();
            
            TabPage tab = new TabPage();
            tab.Text = "New page" + strPagine;
            tabControl1.Controls.Add(tab);
            tabControl1.SelectTab(tabControl1.TabCount - 1);
            webTab = new WebBrowser() { ScriptErrorsSuppressed = true };
            webTab.Parent = tab;
            webTab.Dock = DockStyle.Fill;
            webTab.Navigate($"https://www.{newTabUrl}");
            textBox1.Text = $"https://www.{newTabUrl}";
            webTab.DocumentCompleted += WebTab_DocumentCompleted;
        }

        private void WebTab_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webTab.DocumentTitle;
        }

        private void deleteTabButton_Click(object sender, EventArgs e)
        {
            int selectedTabIndex = tabControl1.SelectedIndex;
            if (selectedTabIndex == -1)
            {
                return;
            }
            tabControl1.TabPages.RemoveAt(selectedTabIndex);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1.Navigate("https://www.google.com");
            webBrowser1.DocumentCompleted += WebBrowser1_DocumentCompleted;
        }

        private void WebBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = webBrowser1.DocumentTitle;
            textBox1.Text = webBrowser1.Url.AbsoluteUri;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
                if (web!=null)
                {
                    web.Navigate(textBox1.Text);
                }
            }
        }
        
        private void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            WebBrowser web = tabControl1.SelectedTab.Controls[0] as WebBrowser;
            if (e.KeyCode == Keys.Enter && textBox1.Text.Trim().Length > 0)
            {
                if (textBox1.Text.Contains("."))
                {
                    web.Navigate(textBox1.Text.Trim());
                }
                else
                {
                    web.Navigate($"https://www.{searchSystem}/search?client=opera&q=" + textBox1.Text.Trim().Replace(" ", "+") + "&sourceid=opera&ie=UTF-8&oe=UTF-8");
                }
            }
        }
            
        private void favoriteButton_Click(object sender, EventArgs e)
        {
            favoriteComboBox.Items.Add(webBrowser1.Url.AbsoluteUri);
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm2(this);
            var result = settingsForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                historyListBox.Items.Clear();
            }
        }

        private void historyButton_Click(object sender, EventArgs e)
        {
            if (!historyListBox.Visible)
            {
                historyListBox.Visible = true;
            }
            else
            {
                historyListBox.Visible = false;
            }
            
        }

        private void webBrowser1_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            historyListBox.Items.Add(tabControl1.SelectedTab.Text);
        }

        private void historyListBox_DoubleClick(object sender, EventArgs e)
        {

        }

    }
}
