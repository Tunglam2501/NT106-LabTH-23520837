namespace Lab02
{
    partial class Lab02_Bai02
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
            this.readButton = new System.Windows.Forms.Button();
            this.fileName = new System.Windows.Forms.Label();
            this.size = new System.Windows.Forms.Label();
            this.url = new System.Windows.Forms.Label();
            this.lineCount = new System.Windows.Forms.Label();
            this.wordCount = new System.Windows.Forms.Label();
            this.characterCount = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.contentRichTextBox = new System.Windows.Forms.RichTextBox();
            this.contentFileName = new System.Windows.Forms.TextBox();
            this.contentSize = new System.Windows.Forms.TextBox();
            this.contentURL = new System.Windows.Forms.TextBox();
            this.contentLineCount = new System.Windows.Forms.TextBox();
            this.contentWordCount = new System.Windows.Forms.TextBox();
            this.contentCharacterCount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // readButton
            // 
            this.readButton.Location = new System.Drawing.Point(16, 15);
            this.readButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.readButton.Name = "readButton";
            this.readButton.Size = new System.Drawing.Size(313, 42);
            this.readButton.TabIndex = 0;
            this.readButton.Text = "Read from file";
            this.readButton.UseVisualStyleBackColor = true;
            this.readButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileName
            // 
            this.fileName.AutoSize = true;
            this.fileName.Location = new System.Drawing.Point(16, 74);
            this.fileName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(66, 16);
            this.fileName.TabIndex = 1;
            this.fileName.Text = "File name";
            // 
            // size
            // 
            this.size.AutoSize = true;
            this.size.Location = new System.Drawing.Point(16, 123);
            this.size.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(33, 16);
            this.size.TabIndex = 2;
            this.size.Text = "Size";
            // 
            // url
            // 
            this.url.AutoSize = true;
            this.url.Location = new System.Drawing.Point(16, 172);
            this.url.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.url.Name = "url";
            this.url.Size = new System.Drawing.Size(34, 16);
            this.url.TabIndex = 3;
            this.url.Text = "URL";
            // 
            // lineCount
            // 
            this.lineCount.AutoSize = true;
            this.lineCount.Location = new System.Drawing.Point(16, 222);
            this.lineCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lineCount.Name = "lineCount";
            this.lineCount.Size = new System.Drawing.Size(69, 16);
            this.lineCount.TabIndex = 4;
            this.lineCount.Text = "Line Count";
            // 
            // wordCount
            // 
            this.wordCount.AutoSize = true;
            this.wordCount.Location = new System.Drawing.Point(16, 271);
            this.wordCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.wordCount.Name = "wordCount";
            this.wordCount.Size = new System.Drawing.Size(84, 16);
            this.wordCount.TabIndex = 5;
            this.wordCount.Text = "Words Count";
            // 
            // characterCount
            // 
            this.characterCount.AutoSize = true;
            this.characterCount.Location = new System.Drawing.Point(16, 320);
            this.characterCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.characterCount.Name = "characterCount";
            this.characterCount.Size = new System.Drawing.Size(102, 16);
            this.characterCount.TabIndex = 6;
            this.characterCount.Text = "Character Count";
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(16, 358);
            this.exit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(313, 38);
            this.exit.TabIndex = 7;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // contentRichTextBox
            // 
            this.contentRichTextBox.Location = new System.Drawing.Point(359, 15);
            this.contentRichTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contentRichTextBox.Name = "contentRichTextBox";
            this.contentRichTextBox.Size = new System.Drawing.Size(323, 381);
            this.contentRichTextBox.TabIndex = 8;
            this.contentRichTextBox.Text = "";
            // 
            // contentFileName
            // 
            this.contentFileName.Location = new System.Drawing.Point(131, 70);
            this.contentFileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contentFileName.Name = "contentFileName";
            this.contentFileName.Size = new System.Drawing.Size(197, 22);
            this.contentFileName.TabIndex = 9;
            // 
            // contentSize
            // 
            this.contentSize.Location = new System.Drawing.Point(131, 119);
            this.contentSize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contentSize.Name = "contentSize";
            this.contentSize.Size = new System.Drawing.Size(197, 22);
            this.contentSize.TabIndex = 10;
            // 
            // contentURL
            // 
            this.contentURL.Location = new System.Drawing.Point(131, 169);
            this.contentURL.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contentURL.Name = "contentURL";
            this.contentURL.Size = new System.Drawing.Size(197, 22);
            this.contentURL.TabIndex = 11;
            // 
            // contentLineCount
            // 
            this.contentLineCount.Location = new System.Drawing.Point(131, 218);
            this.contentLineCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contentLineCount.Name = "contentLineCount";
            this.contentLineCount.Size = new System.Drawing.Size(197, 22);
            this.contentLineCount.TabIndex = 12;
            // 
            // contentWordCount
            // 
            this.contentWordCount.Location = new System.Drawing.Point(131, 267);
            this.contentWordCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contentWordCount.Name = "contentWordCount";
            this.contentWordCount.Size = new System.Drawing.Size(197, 22);
            this.contentWordCount.TabIndex = 13;
            // 
            // contentCharacterCount
            // 
            this.contentCharacterCount.Location = new System.Drawing.Point(131, 316);
            this.contentCharacterCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.contentCharacterCount.Name = "contentCharacterCount";
            this.contentCharacterCount.Size = new System.Drawing.Size(197, 22);
            this.contentCharacterCount.TabIndex = 14;
            // 
            // Lab02_Bai02
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 439);
            this.Controls.Add(this.contentCharacterCount);
            this.Controls.Add(this.contentWordCount);
            this.Controls.Add(this.contentLineCount);
            this.Controls.Add(this.contentURL);
            this.Controls.Add(this.contentSize);
            this.Controls.Add(this.contentFileName);
            this.Controls.Add(this.contentRichTextBox);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.characterCount);
            this.Controls.Add(this.wordCount);
            this.Controls.Add(this.lineCount);
            this.Controls.Add(this.url);
            this.Controls.Add(this.size);
            this.Controls.Add(this.fileName);
            this.Controls.Add(this.readButton);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Lab02_Bai02";
            this.Text = "Lab02_Bai02";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button readButton;
        private System.Windows.Forms.Label fileName;
        private System.Windows.Forms.Label size;
        private System.Windows.Forms.Label url;
        private System.Windows.Forms.Label lineCount;
        private System.Windows.Forms.Label wordCount;
        private System.Windows.Forms.Label characterCount;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RichTextBox contentRichTextBox;
        private System.Windows.Forms.TextBox contentFileName;
        private System.Windows.Forms.TextBox contentSize;
        private System.Windows.Forms.TextBox contentURL;
        private System.Windows.Forms.TextBox contentLineCount;
        private System.Windows.Forms.TextBox contentWordCount;
        private System.Windows.Forms.TextBox contentCharacterCount;
    }
}