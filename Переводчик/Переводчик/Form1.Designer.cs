namespace Translator
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
            this.textTranslateTo = new System.Windows.Forms.RichTextBox();
            this.textTranslateFrom = new System.Windows.Forms.RichTextBox();
            this.toLanguage = new System.Windows.Forms.ComboBox();
            this.fromLanguage = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textTranslateTo
            // 
            this.textTranslateTo.Location = new System.Drawing.Point(399, 124);
            this.textTranslateTo.Name = "textTranslateTo";
            this.textTranslateTo.Size = new System.Drawing.Size(361, 262);
            this.textTranslateTo.TabIndex = 0;
            this.textTranslateTo.Text = "";
            // 
            // textTranslateFrom
            // 
            this.textTranslateFrom.Location = new System.Drawing.Point(12, 124);
            this.textTranslateFrom.Name = "textTranslateFrom";
            this.textTranslateFrom.Size = new System.Drawing.Size(361, 262);
            this.textTranslateFrom.TabIndex = 1;
            this.textTranslateFrom.Text = "";
            this.textTranslateFrom.TextChanged += new System.EventHandler(this.textTranslateFrom_TextChanged);
            // 
            // toLanguage
            // 
            this.toLanguage.FormattingEnabled = true;
            this.toLanguage.Items.AddRange(new object[] {
            "EN",
            "FR",
            "AZ"});
            this.toLanguage.Location = new System.Drawing.Point(500, 66);
            this.toLanguage.Name = "toLanguage";
            this.toLanguage.Size = new System.Drawing.Size(167, 24);
            this.toLanguage.TabIndex = 2;
            this.toLanguage.Text = "Choose language";
            // 
            // fromLanguage
            // 
            this.fromLanguage.FormattingEnabled = true;
            this.fromLanguage.Items.AddRange(new object[] {
            "EN",
            "FR",
            "AZ"});
            this.fromLanguage.Location = new System.Drawing.Point(92, 66);
            this.fromLanguage.Name = "fromLanguage";
            this.fromLanguage.Size = new System.Drawing.Size(167, 24);
            this.fromLanguage.TabIndex = 3;
            this.fromLanguage.Text = "Choose language";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(274, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Глупый переводчик";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(809, 465);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fromLanguage);
            this.Controls.Add(this.toLanguage);
            this.Controls.Add(this.textTranslateFrom);
            this.Controls.Add(this.textTranslateTo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Я поменял название тут!!!";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textTranslateTo;
        private System.Windows.Forms.RichTextBox textTranslateFrom;
        private System.Windows.Forms.ComboBox toLanguage;
        private System.Windows.Forms.ComboBox fromLanguage;
        private System.Windows.Forms.Label label1;
    }
}

