namespace Lab02
{
    partial class Lab02_Bai05
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabBuyTicket = new TabPage();
            groupBoxReceipt = new GroupBox();
            rtbReceipt = new RichTextBox();
            btnBuyTicket = new Button();
            groupBoxSeats = new GroupBox();
            checkedListBoxSeats = new CheckedListBox();
            groupBoxMovie = new GroupBox();
            label3 = new Label();
            cmbRooms = new ComboBox();
            label2 = new Label();
            cmbMovies = new ComboBox();
            groupBoxCustomer = new GroupBox();
            label1 = new Label();
            txtCustomerName = new TextBox();
            tabFileManagement = new TabPage();
            progressBar = new ProgressBar();
            groupBoxFileOutput = new GroupBox();
            btnWriteFile = new Button();
            txtStatistics = new TextBox();
            groupBoxFileInput = new GroupBox();
            btnReadFile = new Button();
            txtFileContent = new TextBox();
            tabControl.SuspendLayout();
            tabBuyTicket.SuspendLayout();
            groupBoxReceipt.SuspendLayout();
            groupBoxSeats.SuspendLayout();
            groupBoxMovie.SuspendLayout();
            groupBoxCustomer.SuspendLayout();
            tabFileManagement.SuspendLayout();
            groupBoxFileOutput.SuspendLayout();
            groupBoxFileInput.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabBuyTicket);
            tabControl.Controls.Add(tabFileManagement);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1000, 812);
            tabControl.TabIndex = 0;
            // 
            // tabBuyTicket
            // 
            tabBuyTicket.Controls.Add(groupBoxReceipt);
            tabBuyTicket.Controls.Add(btnBuyTicket);
            tabBuyTicket.Controls.Add(groupBoxSeats);
            tabBuyTicket.Controls.Add(groupBoxMovie);
            tabBuyTicket.Controls.Add(groupBoxCustomer);
            tabBuyTicket.Location = new Point(4, 29);
            tabBuyTicket.Margin = new Padding(3, 4, 3, 4);
            tabBuyTicket.Name = "tabBuyTicket";
            tabBuyTicket.Padding = new Padding(3, 4, 3, 4);
            tabBuyTicket.Size = new Size(992, 779);
            tabBuyTicket.TabIndex = 0;
            tabBuyTicket.Text = "Mua vé";
            tabBuyTicket.UseVisualStyleBackColor = true;
            // 
            // groupBoxReceipt
            // 
            groupBoxReceipt.Controls.Add(rtbReceipt);
            groupBoxReceipt.Location = new Point(470, 12);
            groupBoxReceipt.Margin = new Padding(3, 4, 3, 4);
            groupBoxReceipt.Name = "groupBoxReceipt";
            groupBoxReceipt.Padding = new Padding(3, 4, 3, 4);
            groupBoxReceipt.Size = new Size(516, 678);
            groupBoxReceipt.TabIndex = 4;
            groupBoxReceipt.TabStop = false;
            groupBoxReceipt.Text = "Hóa đơn";
            // 
            // rtbReceipt
            // 
            rtbReceipt.Font = new Font("Consolas", 9F);
            rtbReceipt.Location = new Point(6, 22);
            rtbReceipt.Margin = new Padding(3, 4, 3, 4);
            rtbReceipt.Name = "rtbReceipt";
            rtbReceipt.ReadOnly = true;
            rtbReceipt.Size = new Size(504, 648);
            rtbReceipt.TabIndex = 0;
            rtbReceipt.Text = "";
            // 
            // btnBuyTicket
            // 
            btnBuyTicket.BackColor = Color.FromArgb(0, 192, 0);
            btnBuyTicket.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold);
            btnBuyTicket.ForeColor = Color.White;
            btnBuyTicket.Location = new Point(10, 628);
            btnBuyTicket.Margin = new Padding(3, 4, 3, 4);
            btnBuyTicket.Name = "btnBuyTicket";
            btnBuyTicket.Size = new Size(450, 62);
            btnBuyTicket.TabIndex = 3;
            btnBuyTicket.Text = "MUA VÉ";
            btnBuyTicket.UseVisualStyleBackColor = false;
            btnBuyTicket.Click += btnBuyTicket_Click;
            // 
            // groupBoxSeats
            // 
            groupBoxSeats.Controls.Add(checkedListBoxSeats);
            groupBoxSeats.Location = new Point(10, 275);
            groupBoxSeats.Margin = new Padding(3, 4, 3, 4);
            groupBoxSeats.Name = "groupBoxSeats";
            groupBoxSeats.Padding = new Padding(3, 4, 3, 4);
            groupBoxSeats.Size = new Size(450, 312);
            groupBoxSeats.TabIndex = 2;
            groupBoxSeats.TabStop = false;
            groupBoxSeats.Text = "Chọn ghế (tối đa 2)";
            // 
            // checkedListBoxSeats
            // 
            checkedListBoxSeats.CheckOnClick = true;
            checkedListBoxSeats.Dock = DockStyle.Fill;
            checkedListBoxSeats.FormattingEnabled = true;
            checkedListBoxSeats.Location = new Point(3, 24);
            checkedListBoxSeats.Margin = new Padding(3, 4, 3, 4);
            checkedListBoxSeats.Name = "checkedListBoxSeats";
            checkedListBoxSeats.Size = new Size(444, 284);
            checkedListBoxSeats.TabIndex = 0;
            // 
            // groupBoxMovie
            // 
            groupBoxMovie.Controls.Add(label3);
            groupBoxMovie.Controls.Add(cmbRooms);
            groupBoxMovie.Controls.Add(label2);
            groupBoxMovie.Controls.Add(cmbMovies);
            groupBoxMovie.Location = new Point(10, 112);
            groupBoxMovie.Margin = new Padding(3, 4, 3, 4);
            groupBoxMovie.Name = "groupBoxMovie";
            groupBoxMovie.Padding = new Padding(3, 4, 3, 4);
            groupBoxMovie.Size = new Size(450, 150);
            groupBoxMovie.TabIndex = 1;
            groupBoxMovie.TabStop = false;
            groupBoxMovie.Text = "Chọn phim và phòng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 91);
            label3.Name = "label3";
            label3.Size = new Size(93, 20);
            label3.TabIndex = 3;
            label3.Text = "Phòng chiếu:";
            // 
            // cmbRooms
            // 
            cmbRooms.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRooms.FormattingEnabled = true;
            cmbRooms.Location = new Point(120, 88);
            cmbRooms.Margin = new Padding(3, 4, 3, 4);
            cmbRooms.Name = "cmbRooms";
            cmbRooms.Size = new Size(300, 28);
            cmbRooms.TabIndex = 2;
            cmbRooms.SelectedIndexChanged += cmbRooms_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 41);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 1;
            label2.Text = "Chọn phim:";
            // 
            // cmbMovies
            // 
            cmbMovies.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMovies.FormattingEnabled = true;
            cmbMovies.Location = new Point(120, 38);
            cmbMovies.Margin = new Padding(3, 4, 3, 4);
            cmbMovies.Name = "cmbMovies";
            cmbMovies.Size = new Size(300, 28);
            cmbMovies.TabIndex = 0;
            cmbMovies.SelectedIndexChanged += cmbMovies_SelectedIndexChanged;
            // 
            // groupBoxCustomer
            // 
            groupBoxCustomer.Controls.Add(label1);
            groupBoxCustomer.Controls.Add(txtCustomerName);
            groupBoxCustomer.Location = new Point(10, 12);
            groupBoxCustomer.Margin = new Padding(3, 4, 3, 4);
            groupBoxCustomer.Name = "groupBoxCustomer";
            groupBoxCustomer.Padding = new Padding(3, 4, 3, 4);
            groupBoxCustomer.Size = new Size(450, 88);
            groupBoxCustomer.TabIndex = 0;
            groupBoxCustomer.TabStop = false;
            groupBoxCustomer.Text = "Thông tin khách hàng";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(15, 41);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Họ và tên KH:";
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(120, 38);
            txtCustomerName.Margin = new Padding(3, 4, 3, 4);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(300, 27);
            txtCustomerName.TabIndex = 0;
            // 
            // tabFileManagement
            // 
            tabFileManagement.Controls.Add(progressBar);
            tabFileManagement.Controls.Add(groupBoxFileOutput);
            tabFileManagement.Controls.Add(groupBoxFileInput);
            tabFileManagement.Location = new Point(4, 29);
            tabFileManagement.Margin = new Padding(3, 4, 3, 4);
            tabFileManagement.Name = "tabFileManagement";
            tabFileManagement.Padding = new Padding(3, 4, 3, 4);
            tabFileManagement.Size = new Size(992, 779);
            tabFileManagement.TabIndex = 1;
            tabFileManagement.Text = "Quản lý File";
            tabFileManagement.UseVisualStyleBackColor = true;
            // 
            // progressBar
            // 
            progressBar.Location = new Point(10, 732);
            progressBar.Margin = new Padding(3, 4, 3, 4);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(970, 31);
            progressBar.TabIndex = 2;
            progressBar.Visible = false;
            // 
            // groupBoxFileOutput
            // 
            groupBoxFileOutput.Controls.Add(btnWriteFile);
            groupBoxFileOutput.Controls.Add(txtStatistics);
            groupBoxFileOutput.Location = new Point(10, 375);
            groupBoxFileOutput.Margin = new Padding(3, 4, 3, 4);
            groupBoxFileOutput.Name = "groupBoxFileOutput";
            groupBoxFileOutput.Padding = new Padding(3, 4, 3, 4);
            groupBoxFileOutput.Size = new Size(970, 350);
            groupBoxFileOutput.TabIndex = 1;
            groupBoxFileOutput.TabStop = false;
            groupBoxFileOutput.Text = "Xuất File Thống Kê (output5.txt)";
            // 
            // btnWriteFile
            // 
            btnWriteFile.BackColor = Color.FromArgb(40, 167, 69);
            btnWriteFile.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnWriteFile.ForeColor = Color.White;
            btnWriteFile.Location = new Point(10, 281);
            btnWriteFile.Margin = new Padding(3, 4, 3, 4);
            btnWriteFile.Name = "btnWriteFile";
            btnWriteFile.Size = new Size(250, 50);
            btnWriteFile.TabIndex = 1;
            btnWriteFile.Text = "XUẤT FILE THỐNG KÊ";
            btnWriteFile.UseVisualStyleBackColor = false;
            btnWriteFile.Click += btnWriteFile_Click;
            // 
            // txtStatistics
            // 
            txtStatistics.Font = new Font("Consolas", 9F);
            txtStatistics.Location = new Point(10, 38);
            txtStatistics.Margin = new Padding(3, 4, 3, 4);
            txtStatistics.Multiline = true;
            txtStatistics.Name = "txtStatistics";
            txtStatistics.ReadOnly = true;
            txtStatistics.ScrollBars = ScrollBars.Both;
            txtStatistics.Size = new Size(950, 224);
            txtStatistics.TabIndex = 0;
            // 
            // groupBoxFileInput
            // 
            groupBoxFileInput.Controls.Add(btnReadFile);
            groupBoxFileInput.Controls.Add(txtFileContent);
            groupBoxFileInput.Location = new Point(10, 12);
            groupBoxFileInput.Margin = new Padding(3, 4, 3, 4);
            groupBoxFileInput.Name = "groupBoxFileInput";
            groupBoxFileInput.Padding = new Padding(3, 4, 3, 4);
            groupBoxFileInput.Size = new Size(970, 350);
            groupBoxFileInput.TabIndex = 0;
            groupBoxFileInput.TabStop = false;
            groupBoxFileInput.Text = "Đọc File Input (input5.txt)";
            // 
            // btnReadFile
            // 
            btnReadFile.BackColor = Color.FromArgb(0, 123, 255);
            btnReadFile.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold);
            btnReadFile.ForeColor = Color.White;
            btnReadFile.Location = new Point(10, 281);
            btnReadFile.Margin = new Padding(3, 4, 3, 4);
            btnReadFile.Name = "btnReadFile";
            btnReadFile.Size = new Size(250, 50);
            btnReadFile.TabIndex = 1;
            btnReadFile.Text = "ĐỌC FILE";
            btnReadFile.UseVisualStyleBackColor = false;
            btnReadFile.Click += btnReadFile_Click;
            // 
            // txtFileContent
            // 
            txtFileContent.Font = new Font("Consolas", 9F);
            txtFileContent.Location = new Point(10, 38);
            txtFileContent.Margin = new Padding(3, 4, 3, 4);
            txtFileContent.Multiline = true;
            txtFileContent.Name = "txtFileContent";
            txtFileContent.ReadOnly = true;
            txtFileContent.ScrollBars = ScrollBars.Both;
            txtFileContent.Size = new Size(950, 224);
            txtFileContent.TabIndex = 0;
            // 
            // Lab02_Bai05
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 812);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Lab02_Bai05";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lab02 - Bài 05: Quản Lý Rạp Phim";
            tabControl.ResumeLayout(false);
            tabBuyTicket.ResumeLayout(false);
            groupBoxReceipt.ResumeLayout(false);
            groupBoxSeats.ResumeLayout(false);
            groupBoxMovie.ResumeLayout(false);
            groupBoxMovie.PerformLayout();
            groupBoxCustomer.ResumeLayout(false);
            groupBoxCustomer.PerformLayout();
            tabFileManagement.ResumeLayout(false);
            groupBoxFileOutput.ResumeLayout(false);
            groupBoxFileOutput.PerformLayout();
            groupBoxFileInput.ResumeLayout(false);
            groupBoxFileInput.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabBuyTicket;
        private System.Windows.Forms.TabPage tabFileManagement;
        private System.Windows.Forms.GroupBox groupBoxCustomer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.GroupBox groupBoxMovie;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbRooms;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbMovies;
        private System.Windows.Forms.GroupBox groupBoxSeats;
        private System.Windows.Forms.CheckedListBox checkedListBoxSeats;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.GroupBox groupBoxReceipt;
        private System.Windows.Forms.RichTextBox rtbReceipt;
        private System.Windows.Forms.GroupBox groupBoxFileInput;
        private System.Windows.Forms.Button btnReadFile;
        private System.Windows.Forms.TextBox txtFileContent;
        private System.Windows.Forms.GroupBox groupBoxFileOutput;
        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.TextBox txtStatistics;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}