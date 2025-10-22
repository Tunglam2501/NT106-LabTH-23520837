namespace Lab02
{
    partial class Lab02_Bai04
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
            txtName = new TextBox();
            txtID = new TextBox();
            txtPhone = new TextBox();
            txtCourse1 = new TextBox();
            txtCourse2 = new TextBox();
            txtCourse3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnAdd = new Button();
            btnWriteFile = new Button();
            btnReadFile = new Button();
            txtDisplayName = new TextBox();
            txtDisplayID = new TextBox();
            txtDisplayPhone = new TextBox();
            txtDisplayCourse1 = new TextBox();
            txtDisplayCourse2 = new TextBox();
            txtDisplayCourse3 = new TextBox();
            txtDisplayAverage = new TextBox();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            btnBack = new Button();
            btnNext = new Button();
            lblPage = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            txtFileContent = new TextBox();
            label14 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(20, 31);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(150, 27);
            txtName.TabIndex = 0;
            // 
            // txtID
            // 
            txtID.Location = new Point(20, 94);
            txtID.Margin = new Padding(3, 4, 3, 4);
            txtID.Name = "txtID";
            txtID.Size = new Size(150, 27);
            txtID.TabIndex = 1;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(20, 156);
            txtPhone.Margin = new Padding(3, 4, 3, 4);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(150, 27);
            txtPhone.TabIndex = 2;
            // 
            // txtCourse1
            // 
            txtCourse1.Location = new Point(20, 219);
            txtCourse1.Margin = new Padding(3, 4, 3, 4);
            txtCourse1.Name = "txtCourse1";
            txtCourse1.Size = new Size(150, 27);
            txtCourse1.TabIndex = 3;
            // 
            // txtCourse2
            // 
            txtCourse2.Location = new Point(20, 281);
            txtCourse2.Margin = new Padding(3, 4, 3, 4);
            txtCourse2.Name = "txtCourse2";
            txtCourse2.Size = new Size(150, 27);
            txtCourse2.TabIndex = 4;
            // 
            // txtCourse3
            // 
            txtCourse3.Location = new Point(20, 344);
            txtCourse3.Margin = new Padding(3, 4, 3, 4);
            txtCourse3.Name = "txtCourse3";
            txtCourse3.Size = new Size(150, 27);
            txtCourse3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 35);
            label1.Name = "label1";
            label1.Size = new Size(49, 20);
            label1.TabIndex = 6;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(190, 98);
            label2.Name = "label2";
            label2.Size = new Size(24, 20);
            label2.TabIndex = 7;
            label2.Text = "ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(190, 160);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "Phone";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(190, 222);
            label4.Name = "label4";
            label4.Size = new Size(66, 20);
            label4.TabIndex = 9;
            label4.Text = "Course 1";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(190, 285);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 10;
            label5.Text = "Course 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(190, 348);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 11;
            label6.Text = "Course 3";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(80, 412);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(100, 44);
            btnAdd.TabIndex = 12;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnWriteFile
            // 
            btnWriteFile.Location = new Point(20, 19);
            btnWriteFile.Margin = new Padding(3, 4, 3, 4);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(220, 44);
            btnWriteFile.TabIndex = 13;
            btnWriteFile.Text = "Write to a File";
            btnWriteFile.UseVisualStyleBackColor = true;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // btnReadFile
            // 
            btnReadFile.BackColor = SystemColors.Window;
            btnReadFile.ForeColor = Color.Black;
            btnReadFile.Location = new Point(20, 19);
            btnReadFile.Margin = new Padding(3, 4, 3, 4);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(220, 44);
            btnReadFile.TabIndex = 14;
            btnReadFile.Text = "Button to read a File";
            btnReadFile.UseVisualStyleBackColor = false;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Location = new Point(20, 94);
            txtDisplayName.Margin = new Padding(3, 4, 3, 4);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.ReadOnly = true;
            txtDisplayName.Size = new Size(150, 27);
            txtDisplayName.TabIndex = 15;
            // 
            // txtDisplayID
            // 
            txtDisplayID.Location = new Point(20, 156);
            txtDisplayID.Margin = new Padding(3, 4, 3, 4);
            txtDisplayID.Name = "txtDisplayID";
            txtDisplayID.ReadOnly = true;
            txtDisplayID.Size = new Size(150, 27);
            txtDisplayID.TabIndex = 16;
            // 
            // txtDisplayPhone
            // 
            txtDisplayPhone.Location = new Point(20, 219);
            txtDisplayPhone.Margin = new Padding(3, 4, 3, 4);
            txtDisplayPhone.Name = "txtDisplayPhone";
            txtDisplayPhone.ReadOnly = true;
            txtDisplayPhone.Size = new Size(150, 27);
            txtDisplayPhone.TabIndex = 17;
            // 
            // txtDisplayCourse1
            // 
            txtDisplayCourse1.Location = new Point(20, 281);
            txtDisplayCourse1.Margin = new Padding(3, 4, 3, 4);
            txtDisplayCourse1.Name = "txtDisplayCourse1";
            txtDisplayCourse1.ReadOnly = true;
            txtDisplayCourse1.Size = new Size(150, 27);
            txtDisplayCourse1.TabIndex = 18;
            // 
            // txtDisplayCourse2
            // 
            txtDisplayCourse2.Location = new Point(20, 344);
            txtDisplayCourse2.Margin = new Padding(3, 4, 3, 4);
            txtDisplayCourse2.Name = "txtDisplayCourse2";
            txtDisplayCourse2.ReadOnly = true;
            txtDisplayCourse2.Size = new Size(150, 27);
            txtDisplayCourse2.TabIndex = 19;
            // 
            // txtDisplayCourse3
            // 
            txtDisplayCourse3.Location = new Point(20, 406);
            txtDisplayCourse3.Margin = new Padding(3, 4, 3, 4);
            txtDisplayCourse3.Name = "txtDisplayCourse3";
            txtDisplayCourse3.ReadOnly = true;
            txtDisplayCourse3.Size = new Size(150, 27);
            txtDisplayCourse3.TabIndex = 20;
            // 
            // txtDisplayAverage
            // 
            txtDisplayAverage.Location = new Point(20, 469);
            txtDisplayAverage.Margin = new Padding(3, 4, 3, 4);
            txtDisplayAverage.Name = "txtDisplayAverage";
            txtDisplayAverage.ReadOnly = true;
            txtDisplayAverage.Size = new Size(150, 27);
            txtDisplayAverage.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(190, 98);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 22;
            label7.Text = "Name";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(190, 160);
            label8.Name = "label8";
            label8.Size = new Size(24, 20);
            label8.TabIndex = 23;
            label8.Text = "ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(190, 222);
            label9.Name = "label9";
            label9.Size = new Size(50, 20);
            label9.TabIndex = 24;
            label9.Text = "Phone";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(190, 285);
            label10.Name = "label10";
            label10.Size = new Size(66, 20);
            label10.TabIndex = 25;
            label10.Text = "Course 1";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(190, 348);
            label11.Name = "label11";
            label11.Size = new Size(66, 20);
            label11.TabIndex = 26;
            label11.Text = "Course 2";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(190, 410);
            label12.Name = "label12";
            label12.Size = new Size(66, 20);
            label12.TabIndex = 27;
            label12.Text = "Course 3";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(190, 472);
            label13.Name = "label13";
            label13.Size = new Size(64, 20);
            label13.TabIndex = 28;
            label13.Text = "Average";
            // 
            // btnBack
            // 
            btnBack.Location = new Point(20, 538);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 38);
            btnBack.TabIndex = 29;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(165, 538);
            btnNext.Margin = new Padding(3, 4, 3, 4);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(75, 38);
            btnNext.TabIndex = 30;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // lblPage
            // 
            lblPage.AutoSize = true;
            lblPage.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPage.Location = new Point(115, 544);
            lblPage.Name = "lblPage";
            lblPage.Size = new Size(19, 20);
            lblPage.TabIndex = 31;
            lblPage.Text = "1";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(txtName);
            panel1.Controls.Add(txtID);
            panel1.Controls.Add(txtPhone);
            panel1.Controls.Add(txtCourse1);
            panel1.Controls.Add(txtCourse2);
            panel1.Controls.Add(txtCourse3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(btnAdd);
            panel1.Location = new Point(20, 112);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(260, 513);
            panel1.TabIndex = 32;
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.Controls.Add(btnWriteFile);
            panel2.Location = new Point(20, 25);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(260, 81);
            panel2.TabIndex = 33;
            // 
            // panel3
            // 
            panel3.BackColor = Color.WhiteSmoke;
            panel3.Controls.Add(btnReadFile);
            panel3.Controls.Add(txtDisplayName);
            panel3.Controls.Add(txtDisplayID);
            panel3.Controls.Add(txtDisplayPhone);
            panel3.Controls.Add(txtDisplayCourse1);
            panel3.Controls.Add(lblPage);
            panel3.Controls.Add(txtDisplayCourse2);
            panel3.Controls.Add(btnNext);
            panel3.Controls.Add(txtDisplayCourse3);
            panel3.Controls.Add(btnBack);
            panel3.Controls.Add(txtDisplayAverage);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label10);
            panel3.Location = new Point(580, 25);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(260, 600);
            panel3.TabIndex = 34;
            // 
            // txtFileContent
            // 
            txtFileContent.BackColor = Color.White;
            txtFileContent.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFileContent.Location = new Point(290, 25);
            txtFileContent.Margin = new Padding(3, 4, 3, 4);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.ReadOnly = true;
            txtFileContent.ScrollBars = ScrollBars.Vertical;
            txtFileContent.Size = new Size(280, 600);
            txtFileContent.TabIndex = 35;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label14.Location = new Point(290, 9);
            label14.Name = "label14";
            label14.Size = new Size(99, 18);
            label14.TabIndex = 36;
            label14.Text = "File Content";
            // 
            // Lab02_Bai04
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 638);
            Controls.Add(label14);
            Controls.Add(txtFileContent);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Lab02_Bai04";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản lý Sinh viên - JsonSerializer";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCourse1;
        private System.Windows.Forms.TextBox txtCourse2;
        private System.Windows.Forms.TextBox txtCourse3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox txtDisplayName;
        private System.Windows.Forms.TextBox txtDisplayID;
        private System.Windows.Forms.TextBox txtDisplayPhone;
        private System.Windows.Forms.TextBox txtDisplayCourse1;
        private System.Windows.Forms.TextBox txtDisplayCourse2;
        private System.Windows.Forms.TextBox txtDisplayCourse3;
        private System.Windows.Forms.TextBox txtDisplayAverage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtFileContent;
        private System.Windows.Forms.Label label14;
    }
}