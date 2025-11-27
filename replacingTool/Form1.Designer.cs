namespace replacingTool
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtKeyFile = new TextBox();
            txtInputFile = new TextBox();
            txtOutputFile = new TextBox();
            btnBrowseKey = new Button();
            btnBrowseInput = new Button();
            btnBrowseOutput = new Button();
            btnReplace = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(130, 86);
            label1.Name = "label1";
            label1.Size = new Size(118, 25);
            label1.TabIndex = 0;
            label1.Text = "Key Value File";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(149, 194);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 1;
            label2.Text = "Input File";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(134, 299);
            label3.Name = "label3";
            label3.Size = new Size(100, 25);
            label3.TabIndex = 2;
            label3.Text = "Output File";
            // 
            // txtKeyFile
            // 
            txtKeyFile.Location = new Point(295, 80);
            txtKeyFile.Name = "txtKeyFile";
            txtKeyFile.PlaceholderText = "txtKeyFile";
            txtKeyFile.Size = new Size(195, 31);
            txtKeyFile.TabIndex = 3;
            txtKeyFile.TextChanged += textBox1_TextChanged;
            // 
            // txtInputFile
            // 
            txtInputFile.Location = new Point(295, 194);
            txtInputFile.Name = "txtInputFile";
            txtInputFile.PlaceholderText = "txtInputFile";
            txtInputFile.Size = new Size(195, 31);
            txtInputFile.TabIndex = 4;
            // 
            // txtOutputFile
            // 
            txtOutputFile.Location = new Point(295, 299);
            txtOutputFile.Name = "txtOutputFile";
            txtOutputFile.PlaceholderText = "txtOutputFile";
            txtOutputFile.Size = new Size(202, 31);
            txtOutputFile.TabIndex = 5;
            // 
            // btnBrowseKey
            // 
            btnBrowseKey.Location = new Point(556, 81);
            btnBrowseKey.Name = "btnBrowseKey";
            btnBrowseKey.Size = new Size(112, 34);
            btnBrowseKey.TabIndex = 6;
            btnBrowseKey.Text = "Browse...";
            btnBrowseKey.UseVisualStyleBackColor = true;
            btnBrowseKey.Click += btnBrowseKey_Click;
            // 
            // btnBrowseInput
            // 
            btnBrowseInput.Location = new Point(556, 194);
            btnBrowseInput.Name = "btnBrowseInput";
            btnBrowseInput.Size = new Size(112, 34);
            btnBrowseInput.TabIndex = 7;
            btnBrowseInput.Text = "Browse...";
            btnBrowseInput.UseVisualStyleBackColor = true;
            btnBrowseInput.Click += button2_Click;
            // 
            // btnBrowseOutput
            // 
            btnBrowseOutput.Location = new Point(556, 290);
            btnBrowseOutput.Name = "btnBrowseOutput";
            btnBrowseOutput.Size = new Size(112, 34);
            btnBrowseOutput.TabIndex = 8;
            btnBrowseOutput.Text = "Browse...";
            btnBrowseOutput.UseVisualStyleBackColor = true;
            btnBrowseOutput.Click += btnBrowseOutput_Click;
            // 
            // btnReplace
            // 
            btnReplace.Location = new Point(259, 382);
            btnReplace.Name = "btnReplace";
            btnReplace.Size = new Size(231, 42);
            btnReplace.TabIndex = 9;
            btnReplace.Text = "Replace Now";
            btnReplace.UseVisualStyleBackColor = true;
            btnReplace.Click += btnReplace_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1074, 450);
            Controls.Add(btnReplace);
            Controls.Add(btnBrowseOutput);
            Controls.Add(btnBrowseInput);
            Controls.Add(btnBrowseKey);
            Controls.Add(txtOutputFile);
            Controls.Add(txtInputFile);
            Controls.Add(txtKeyFile);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtKeyFile;
        private TextBox txtInputFile;
        private TextBox txtOutputFile;
        private Button btnBrowseKey;
        private Button btnBrowseInput;
        private Button btnBrowseOutput;
        private Button btnReplace;
    }
}
