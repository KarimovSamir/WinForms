namespace Browser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.homeButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.enterButton = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.addTabButton = new System.Windows.Forms.Button();
            this.deleteTabButton = new System.Windows.Forms.Button();
            this.favoriteButton = new System.Windows.Forms.Button();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.settingsButton = new System.Windows.Forms.Button();
            this.historyButton = new System.Windows.Forms.Button();
            this.favoriteComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(0, 4);
            this.leftButton.Margin = new System.Windows.Forms.Padding(4);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(73, 46);
            this.leftButton.TabIndex = 1;
            this.leftButton.Text = "<--";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(82, 4);
            this.rightButton.Margin = new System.Windows.Forms.Padding(4);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(73, 46);
            this.rightButton.TabIndex = 2;
            this.rightButton.Text = "-->";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(163, 4);
            this.refreshButton.Margin = new System.Windows.Forms.Padding(4);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(73, 46);
            this.refreshButton.TabIndex = 3;
            this.refreshButton.Text = "refresh";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // homeButton
            // 
            this.homeButton.Location = new System.Drawing.Point(244, 4);
            this.homeButton.Margin = new System.Windows.Forms.Padding(4);
            this.homeButton.Name = "homeButton";
            this.homeButton.Size = new System.Drawing.Size(73, 46);
            this.homeButton.TabIndex = 4;
            this.homeButton.Text = "home";
            this.homeButton.UseVisualStyleBackColor = true;
            this.homeButton.Click += new System.EventHandler(this.homeButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(488, 4);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(586, 22);
            this.textBox1.TabIndex = 5;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(1082, 0);
            this.enterButton.Margin = new System.Windows.Forms.Padding(4);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(88, 61);
            this.enterButton.TabIndex = 6;
            this.enterButton.Text = "enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.enterButton_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1162, 633);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.webBrowser1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1154, 604);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(4, 4);
            this.webBrowser1.Margin = new System.Windows.Forms.Padding(4);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(27, 25);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1146, 596);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.Navigated += new System.Windows.Forms.WebBrowserNavigatedEventHandler(this.webBrowser1_Navigated);
            // 
            // addTabButton
            // 
            this.addTabButton.Location = new System.Drawing.Point(326, 4);
            this.addTabButton.Margin = new System.Windows.Forms.Padding(4);
            this.addTabButton.Name = "addTabButton";
            this.addTabButton.Size = new System.Drawing.Size(73, 46);
            this.addTabButton.TabIndex = 8;
            this.addTabButton.Text = "Add tab";
            this.addTabButton.UseVisualStyleBackColor = true;
            this.addTabButton.Click += new System.EventHandler(this.addTabButton_Click);
            // 
            // deleteTabButton
            // 
            this.deleteTabButton.Location = new System.Drawing.Point(407, 4);
            this.deleteTabButton.Margin = new System.Windows.Forms.Padding(4);
            this.deleteTabButton.Name = "deleteTabButton";
            this.deleteTabButton.Size = new System.Drawing.Size(73, 46);
            this.deleteTabButton.TabIndex = 9;
            this.deleteTabButton.Text = "Delete tab";
            this.deleteTabButton.UseVisualStyleBackColor = true;
            this.deleteTabButton.Click += new System.EventHandler(this.deleteTabButton_Click);
            // 
            // favoriteButton
            // 
            this.favoriteButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.favoriteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.favoriteButton.Location = new System.Drawing.Point(1310, 0);
            this.favoriteButton.Margin = new System.Windows.Forms.Padding(4);
            this.favoriteButton.Name = "favoriteButton";
            this.favoriteButton.Size = new System.Drawing.Size(73, 61);
            this.favoriteButton.TabIndex = 10;
            this.favoriteButton.Text = "⭐";
            this.favoriteButton.UseVisualStyleBackColor = true;
            this.favoriteButton.Click += new System.EventHandler(this.favoriteButton_Click);
            // 
            // historyListBox
            // 
            this.historyListBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.HorizontalScrollbar = true;
            this.historyListBox.ItemHeight = 16;
            this.historyListBox.Location = new System.Drawing.Point(1162, 0);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(205, 631);
            this.historyListBox.TabIndex = 1;
            this.historyListBox.Visible = false;
            this.historyListBox.DoubleClick += new System.EventHandler(this.historyListBox_DoubleClick);
            // 
            // settingsButton
            // 
            this.settingsButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.settingsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.settingsButton.Location = new System.Drawing.Point(1237, 0);
            this.settingsButton.Margin = new System.Windows.Forms.Padding(4);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Size = new System.Drawing.Size(73, 61);
            this.settingsButton.TabIndex = 11;
            this.settingsButton.Text = "⚙";
            this.settingsButton.UseVisualStyleBackColor = true;
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // historyButton
            // 
            this.historyButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.historyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.historyButton.Location = new System.Drawing.Point(1164, 0);
            this.historyButton.Margin = new System.Windows.Forms.Padding(4);
            this.historyButton.Name = "historyButton";
            this.historyButton.Size = new System.Drawing.Size(73, 61);
            this.historyButton.TabIndex = 12;
            this.historyButton.Text = "📖";
            this.historyButton.UseVisualStyleBackColor = true;
            this.historyButton.Click += new System.EventHandler(this.historyButton_Click);
            // 
            // favoriteComboBox
            // 
            this.favoriteComboBox.FormattingEnabled = true;
            this.favoriteComboBox.Location = new System.Drawing.Point(487, 33);
            this.favoriteComboBox.Name = "favoriteComboBox";
            this.favoriteComboBox.Size = new System.Drawing.Size(587, 24);
            this.favoriteComboBox.TabIndex = 13;
            this.favoriteComboBox.Text = "Favorite";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.favoriteComboBox);
            this.panel1.Controls.Add(this.historyButton);
            this.panel1.Controls.Add(this.enterButton);
            this.panel1.Controls.Add(this.leftButton);
            this.panel1.Controls.Add(this.settingsButton);
            this.panel1.Controls.Add(this.rightButton);
            this.panel1.Controls.Add(this.refreshButton);
            this.panel1.Controls.Add(this.favoriteButton);
            this.panel1.Controls.Add(this.homeButton);
            this.panel1.Controls.Add(this.addTabButton);
            this.panel1.Controls.Add(this.deleteTabButton);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1383, 61);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tabControl1);
            this.panel2.Controls.Add(this.historyListBox);
            this.panel2.Location = new System.Drawing.Point(0, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1367, 631);
            this.panel2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1383, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Sam Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Button homeButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button addTabButton;
        private System.Windows.Forms.Button deleteTabButton;
        private System.Windows.Forms.Button favoriteButton;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.Button settingsButton;
        private System.Windows.Forms.Button historyButton;
        private System.Windows.Forms.ComboBox favoriteComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

