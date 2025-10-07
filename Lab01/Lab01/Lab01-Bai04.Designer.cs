namespace Lab01
{
    partial class Lab01_Bai04
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.cmbMovies = new System.Windows.Forms.ComboBox();
            this.cmbRooms = new System.Windows.Forms.ComboBox();
            this.checkedListBoxSeats = new System.Windows.Forms.CheckedListBox();
            this.btnBuyTicket = new System.Windows.Forms.Button();
            this.rtbReceipt = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên khách hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên phim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 192);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Phòng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chọn ghế:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Location = new System.Drawing.Point(105, 87);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(186, 22);
            this.txtCustomerName.TabIndex = 4;
            // 
            // cmbMovies
            // 
            this.cmbMovies.FormattingEnabled = true;
            this.cmbMovies.Location = new System.Drawing.Point(108, 149);
            this.cmbMovies.Name = "cmbMovies";
            this.cmbMovies.Size = new System.Drawing.Size(183, 24);
            this.cmbMovies.TabIndex = 5;
            this.cmbMovies.SelectedIndexChanged += new System.EventHandler(this.cmbMovies_SelectedIndexChanged);
            // 
            // cmbRooms
            // 
            this.cmbRooms.FormattingEnabled = true;
            this.cmbRooms.Location = new System.Drawing.Point(105, 213);
            this.cmbRooms.Name = "cmbRooms";
            this.cmbRooms.Size = new System.Drawing.Size(186, 24);
            this.cmbRooms.TabIndex = 6;
            this.cmbRooms.SelectedIndexChanged += new System.EventHandler(this.cmbRooms_SelectedIndexChanged);
            // 
            // checkedListBoxSeats
            // 
            this.checkedListBoxSeats.FormattingEnabled = true;
            this.checkedListBoxSeats.Location = new System.Drawing.Point(105, 275);
            this.checkedListBoxSeats.Name = "checkedListBoxSeats";
            this.checkedListBoxSeats.Size = new System.Drawing.Size(338, 106);
            this.checkedListBoxSeats.TabIndex = 7;
            // 
            // btnBuyTicket
            // 
            this.btnBuyTicket.Location = new System.Drawing.Point(238, 396);
            this.btnBuyTicket.Name = "btnBuyTicket";
            this.btnBuyTicket.Size = new System.Drawing.Size(75, 23);
            this.btnBuyTicket.TabIndex = 8;
            this.btnBuyTicket.Text = "Mua vé";
            this.btnBuyTicket.UseVisualStyleBackColor = true;
            this.btnBuyTicket.Click += new System.EventHandler(this.btnBuyTicket_Click);
            // 
            // rtbReceipt
            // 
            this.rtbReceipt.Location = new System.Drawing.Point(493, 112);
            this.rtbReceipt.Name = "rtbReceipt";
            this.rtbReceipt.Size = new System.Drawing.Size(217, 269);
            this.rtbReceipt.TabIndex = 9;
            this.rtbReceipt.Text = "";
            // 
            // Lab01_Bai04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbReceipt);
            this.Controls.Add(this.btnBuyTicket);
            this.Controls.Add(this.checkedListBoxSeats);
            this.Controls.Add(this.cmbRooms);
            this.Controls.Add(this.cmbMovies);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Lab01_Bai04";
            this.Text = "Lab01_Bai04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.ComboBox cmbMovies;
        private System.Windows.Forms.ComboBox cmbRooms;
        private System.Windows.Forms.CheckedListBox checkedListBoxSeats;
        private System.Windows.Forms.Button btnBuyTicket;
        private System.Windows.Forms.RichTextBox rtbReceipt;
    }
}