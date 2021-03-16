namespace CompileExamV2
{
    partial class CreateOrOpenProjectForm
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
            this.openProjectButton = new System.Windows.Forms.Button();
            this.createProjectButton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label2 = new System.Windows.Forms.Label();
            this.exitFormCOOPButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(52, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 53);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sam Studio 2077";
            // 
            // openProjectButton
            // 
            this.openProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.openProjectButton.Location = new System.Drawing.Point(50, 219);
            this.openProjectButton.Name = "openProjectButton";
            this.openProjectButton.Size = new System.Drawing.Size(329, 120);
            this.openProjectButton.TabIndex = 2;
            this.openProjectButton.Text = "📂 Open project";
            this.openProjectButton.UseVisualStyleBackColor = true;
            this.openProjectButton.Click += new System.EventHandler(this.openProjectButton_Click);
            // 
            // createProjectButton
            // 
            this.createProjectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createProjectButton.Location = new System.Drawing.Point(50, 388);
            this.createProjectButton.Name = "createProjectButton";
            this.createProjectButton.Size = new System.Drawing.Size(329, 120);
            this.createProjectButton.TabIndex = 3;
            this.createProjectButton.Text = "🆕 Create project";
            this.createProjectButton.UseVisualStyleBackColor = true;
            this.createProjectButton.Click += new System.EventHandler(this.createProjectButton_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(117, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 54);
            this.label2.TabIndex = 4;
            this.label2.Text = "Get started";
            // 
            // exitFormCOOPButton
            // 
            this.exitFormCOOPButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.exitFormCOOPButton.Location = new System.Drawing.Point(170, 546);
            this.exitFormCOOPButton.Name = "exitFormCOOPButton";
            this.exitFormCOOPButton.Size = new System.Drawing.Size(88, 74);
            this.exitFormCOOPButton.TabIndex = 5;
            this.exitFormCOOPButton.Text = "Exit";
            this.exitFormCOOPButton.UseVisualStyleBackColor = true;
            this.exitFormCOOPButton.Click += new System.EventHandler(this.exitFormCOOPButton_Click);
            // 
            // CreateOrOpenProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(448, 682);
            this.ControlBox = false;
            this.Controls.Add(this.exitFormCOOPButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.createProjectButton);
            this.Controls.Add(this.openProjectButton);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "CreateOrOpenProjectForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sam Studio 2077";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button openProjectButton;
        private System.Windows.Forms.Button createProjectButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button exitFormCOOPButton;
    }
}