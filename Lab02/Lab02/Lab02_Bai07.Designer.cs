namespace Lab02
{
    partial class Lab02_Bai07
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
            splitContainer1 = new SplitContainer();
            directoryTreeView = new TreeView();
            contentGroupBox = new GroupBox();
            fileContentTextBox = new TextBox();
            imagePreviewBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            contentGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagePreviewBox).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 4, 3, 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(directoryTreeView);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(contentGroupBox);
            splitContainer1.Size = new Size(825, 596);
            splitContainer1.SplitterDistance = 275;
            splitContainer1.TabIndex = 0;
            // 
            // directoryTreeView
            // 
            directoryTreeView.Location = new Point(3, 15);
            directoryTreeView.Margin = new Padding(3, 4, 3, 4);
            directoryTreeView.Name = "directoryTreeView";
            directoryTreeView.Size = new Size(269, 565);
            directoryTreeView.TabIndex = 0;
            directoryTreeView.BeforeExpand += directoryTreeView_BeforeExpand;
            directoryTreeView.AfterSelect += directoryTreeView_AfterSelect;
            // 
            // contentGroupBox
            // 
            contentGroupBox.Controls.Add(fileContentTextBox);
            contentGroupBox.Controls.Add(imagePreviewBox);
            contentGroupBox.Location = new Point(3, 15);
            contentGroupBox.Margin = new Padding(3, 4, 3, 4);
            contentGroupBox.Name = "contentGroupBox";
            contentGroupBox.Padding = new Padding(3, 4, 3, 4);
            contentGroupBox.Size = new Size(531, 566);
            contentGroupBox.TabIndex = 0;
            contentGroupBox.TabStop = false;
            contentGroupBox.Text = "File Content";
            // 
            // fileContentTextBox
            // 
            fileContentTextBox.Location = new Point(6, 26);
            fileContentTextBox.Margin = new Padding(3, 4, 3, 4);
            fileContentTextBox.Multiline = true;
            fileContentTextBox.Name = "fileContentTextBox";
            fileContentTextBox.ReadOnly = true;
            fileContentTextBox.Size = new Size(519, 530);
            fileContentTextBox.TabIndex = 1;
            fileContentTextBox.Visible = false;
            // 
            // imagePreviewBox
            // 
            imagePreviewBox.Location = new Point(6, 26);
            imagePreviewBox.Margin = new Padding(3, 4, 3, 4);
            imagePreviewBox.Name = "imagePreviewBox";
            imagePreviewBox.Size = new Size(519, 532);
            imagePreviewBox.SizeMode = PictureBoxSizeMode.Zoom;
            imagePreviewBox.TabIndex = 0;
            imagePreviewBox.TabStop = false;
            imagePreviewBox.Visible = false;
            // 
            // Lab02_Bai07
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(825, 596);
            Controls.Add(splitContainer1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lab02_Bai07";
            Text = "Lab02_Bai07";
            Load += Lab02_Bai07_Load;
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            contentGroupBox.ResumeLayout(false);
            contentGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagePreviewBox).EndInit();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView directoryTreeView;
        private System.Windows.Forms.GroupBox contentGroupBox;
        private System.Windows.Forms.PictureBox imagePreviewBox;
        private System.Windows.Forms.TextBox fileContentTextBox;
    }
}