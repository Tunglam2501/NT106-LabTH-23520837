namespace Lab02
{
    partial class Lab02_Bai03
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
            readButton = new Button();
            writeButton = new Button();
            groupBox1 = new GroupBox();
            contentReadFile = new RichTextBox();
            groupBox2 = new GroupBox();
            contentWriteFile = new RichTextBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // readButton
            // 
            readButton.Location = new Point(105, 110);
            readButton.Margin = new Padding(3, 4, 3, 4);
            readButton.Name = "readButton";
            readButton.Size = new Size(264, 54);
            readButton.TabIndex = 0;
            readButton.Text = "Read File";
            readButton.UseVisualStyleBackColor = true;
            readButton.Click += button1_Click;
            // 
            // writeButton
            // 
            writeButton.Location = new Point(443, 110);
            writeButton.Margin = new Padding(3, 4, 3, 4);
            writeButton.Name = "writeButton";
            writeButton.Size = new Size(264, 54);
            writeButton.TabIndex = 1;
            writeButton.Text = "WriteFile";
            writeButton.UseVisualStyleBackColor = true;
            writeButton.Click += writeButton_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(contentReadFile);
            groupBox1.Location = new Point(105, 188);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(264, 255);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Mathematical Expression";
            // 
            // contentReadFile
            // 
            contentReadFile.Location = new Point(0, 28);
            contentReadFile.Margin = new Padding(3, 4, 3, 4);
            contentReadFile.Name = "contentReadFile";
            contentReadFile.ReadOnly = true;
            contentReadFile.Size = new Size(264, 226);
            contentReadFile.TabIndex = 0;
            contentReadFile.Text = "";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(contentWriteFile);
            groupBox2.Location = new Point(443, 188);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(264, 255);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Calculate ";
            // 
            // contentWriteFile
            // 
            contentWriteFile.Location = new Point(0, 28);
            contentWriteFile.Margin = new Padding(3, 4, 3, 4);
            contentWriteFile.Name = "contentWriteFile";
            contentWriteFile.ReadOnly = true;
            contentWriteFile.Size = new Size(264, 226);
            contentWriteFile.TabIndex = 1;
            contentWriteFile.Text = "";
            // 
            // Lab02_Bai03
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(writeButton);
            Controls.Add(readButton);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lab02_Bai03";
            Text = "Lab02_Bai03";
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Button writeButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox contentReadFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox contentWriteFile;
    }
}