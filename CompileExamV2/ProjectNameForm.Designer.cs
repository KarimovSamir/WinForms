namespace CompileExamV2
{
    partial class ProjectNameForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.startProjectButton = new System.Windows.Forms.Button();
            this.exitNameProjectButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Напишите название проекта";
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(27, 85);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(412, 22);
            this.projectNameTextBox.TabIndex = 1;
            // 
            // startProjectButton
            // 
            this.startProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.startProjectButton.Location = new System.Drawing.Point(57, 130);
            this.startProjectButton.Name = "startProjectButton";
            this.startProjectButton.Size = new System.Drawing.Size(131, 65);
            this.startProjectButton.TabIndex = 2;
            this.startProjectButton.Text = "Начать работу";
            this.startProjectButton.UseVisualStyleBackColor = true;
            this.startProjectButton.Click += new System.EventHandler(this.startProjectButton_Click);
            // 
            // exitNameProjectButton
            // 
            this.exitNameProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitNameProjectButton.Location = new System.Drawing.Point(272, 130);
            this.exitNameProjectButton.Name = "exitNameProjectButton";
            this.exitNameProjectButton.Size = new System.Drawing.Size(131, 65);
            this.exitNameProjectButton.TabIndex = 3;
            this.exitNameProjectButton.Text = "Выход";
            this.exitNameProjectButton.UseVisualStyleBackColor = true;
            this.exitNameProjectButton.Click += new System.EventHandler(this.exitNameProjectButton_Click);
            // 
            // ProjectNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(474, 243);
            this.ControlBox = false;
            this.Controls.Add(this.exitNameProjectButton);
            this.Controls.Add(this.startProjectButton);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ProjectNameForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sam Studio 2077";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox projectNameTextBox;
        private System.Windows.Forms.Button startProjectButton;
        private System.Windows.Forms.Button exitNameProjectButton;
    }
}