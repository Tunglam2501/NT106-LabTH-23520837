namespace Lab02
{
    partial class Lab02_Bai06
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
            lvMonAn = new ListView();
            colTenMonAn = new ColumnHeader();
            label1 = new Label();
            groupBox1 = new GroupBox();
            label2 = new Label();
            lblNguoiDongGop = new Label();
            lblTenMonAnChon = new Label();
            picMonAn = new PictureBox();
            btnChonNgauNhien = new Button();
            groupBox2 = new GroupBox();
            label6 = new Label();
            cboNguoiDung = new ComboBox();
            txtHinhAnh = new TextBox();
            label4 = new Label();
            btnXoa = new Button();
            btnThem = new Button();
            txtTenMonAnMoi = new TextBox();
            label3 = new Label();
            btnThoat = new Button();
            groupBox3 = new GroupBox();
            btnThemNguoiDung = new Button();
            txtTenNguoiDung = new TextBox();
            label5 = new Label();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picMonAn).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // lvMonAn
            // 
            lvMonAn.Columns.AddRange(new ColumnHeader[] { colTenMonAn });
            lvMonAn.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lvMonAn.FullRowSelect = true;
            lvMonAn.GridLines = true;
            lvMonAn.Location = new Point(16, 46);
            lvMonAn.Margin = new Padding(4, 5, 4, 5);
            lvMonAn.Name = "lvMonAn";
            lvMonAn.Size = new Size(436, 335);
            lvMonAn.TabIndex = 0;
            lvMonAn.UseCompatibleStateImageBehavior = false;
            lvMonAn.View = View.Details;
            // 
            // colTenMonAn
            // 
            colTenMonAn.Text = "Tên Món Ăn";
            colTenMonAn.Width = 320;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 17);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(172, 20);
            label1.TabIndex = 1;
            label1.Text = "Danh sách món ăn:";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(lblNguoiDongGop);
            groupBox1.Controls.Add(lblTenMonAnChon);
            groupBox1.Controls.Add(picMonAn);
            groupBox1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.Location = new Point(483, 46);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(568, 461);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Món Ăn Cho Hôm Nay";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(356, 391);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(189, 18);
            label2.TabIndex = 3;
            label2.Text = "Món ăn được đóng góp bởi:";
            // 
            // lblNguoiDongGop
            // 
            lblNguoiDongGop.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblNguoiDongGop.Location = new Point(24, 426);
            lblNguoiDongGop.Margin = new Padding(4, 0, 4, 0);
            lblNguoiDongGop.Name = "lblNguoiDongGop";
            lblNguoiDongGop.Size = new Size(517, 35);
            lblNguoiDongGop.TabIndex = 2;
            lblNguoiDongGop.Text = "Người đóng góp...";
            lblNguoiDongGop.TextAlign = ContentAlignment.MiddleRight;
            // 
            // lblTenMonAnChon
            // 
            lblTenMonAnChon.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTenMonAnChon.ForeColor = Color.Firebrick;
            lblTenMonAnChon.Location = new Point(24, 342);
            lblTenMonAnChon.Margin = new Padding(4, 0, 4, 0);
            lblTenMonAnChon.Name = "lblTenMonAnChon";
            lblTenMonAnChon.Size = new Size(517, 49);
            lblTenMonAnChon.TabIndex = 1;
            lblTenMonAnChon.Text = "Hãy chọn một món ăn!";
            lblTenMonAnChon.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // picMonAn
            // 
            picMonAn.BorderStyle = BorderStyle.FixedSingle;
            picMonAn.Location = new Point(24, 58);
            picMonAn.Margin = new Padding(4, 5, 4, 5);
            picMonAn.Name = "picMonAn";
            picMonAn.Size = new Size(517, 277);
            picMonAn.SizeMode = PictureBoxSizeMode.Zoom;
            picMonAn.TabIndex = 0;
            picMonAn.TabStop = false;
            // 
            // btnChonNgauNhien
            // 
            btnChonNgauNhien.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChonNgauNhien.Location = new Point(16, 403);
            btnChonNgauNhien.Margin = new Padding(4, 5, 4, 5);
            btnChonNgauNhien.Name = "btnChonNgauNhien";
            btnChonNgauNhien.Size = new Size(436, 104);
            btnChonNgauNhien.TabIndex = 3;
            btnChonNgauNhien.Text = "ĂN GÌ ĐÂY?";
            btnChonNgauNhien.UseVisualStyleBackColor = true;
            btnChonNgauNhien.Click += btnChonNgauNhien_Click;
            // 
            // groupBox2
            // 
            groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(cboNguoiDung);
            groupBox2.Controls.Add(txtHinhAnh);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(btnXoa);
            groupBox2.Controls.Add(btnThem);
            groupBox2.Controls.Add(txtTenMonAnMoi);
            groupBox2.Controls.Add(label3);
            groupBox2.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox2.Location = new Point(15, 517);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(437, 306);
            groupBox2.TabIndex = 4;
            groupBox2.TabStop = false;
            groupBox2.Text = "Quản lý món ăn";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 165);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(130, 20);
            label6.TabIndex = 7;
            label6.Text = "Người đóng góp:";
            // 
            // cboNguoiDung
            // 
            cboNguoiDung.DropDownStyle = ComboBoxStyle.DropDownList;
            cboNguoiDung.FormattingEnabled = true;
            cboNguoiDung.Location = new Point(25, 194);
            cboNguoiDung.Margin = new Padding(4, 5, 4, 5);
            cboNguoiDung.Name = "cboNguoiDung";
            cboNguoiDung.Size = new Size(383, 28);
            cboNguoiDung.TabIndex = 6;
            // 
            // txtHinhAnh
            // 
            txtHinhAnh.Location = new Point(25, 126);
            txtHinhAnh.Margin = new Padding(4, 5, 4, 5);
            txtHinhAnh.Name = "txtHinhAnh";
            txtHinhAnh.Size = new Size(383, 26);
            txtHinhAnh.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(21, 97);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(185, 20);
            label4.TabIndex = 4;
            label4.Text = "Tên file ảnh (vd: a.png):";
            // 
            // btnXoa
            // 
            btnXoa.Location = new Point(309, 245);
            btnXoa.Margin = new Padding(4, 5, 4, 5);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 46);
            btnXoa.TabIndex = 3;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = true;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.Location = new Point(201, 245);
            btnThem.Margin = new Padding(4, 5, 4, 5);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(100, 46);
            btnThem.TabIndex = 2;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = true;
            btnThem.Click += btnThem_Click;
            // 
            // txtTenMonAnMoi
            // 
            txtTenMonAnMoi.Location = new Point(25, 57);
            txtTenMonAnMoi.Margin = new Padding(4, 5, 4, 5);
            txtTenMonAnMoi.Name = "txtTenMonAnMoi";
            txtTenMonAnMoi.Size = new Size(383, 26);
            txtTenMonAnMoi.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(21, 28);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(145, 20);
            label3.TabIndex = 0;
            label3.Text = "Nhập món ăn mới:";
            // 
            // btnThoat
            // 
            btnThoat.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            btnThoat.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnThoat.Location = new Point(483, 728);
            btnThoat.Margin = new Padding(4, 5, 4, 5);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(568, 95);
            btnThoat.TabIndex = 5;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = true;
            btnThoat.Click += btnThoat_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnThemNguoiDung);
            groupBox3.Controls.Add(txtTenNguoiDung);
            groupBox3.Controls.Add(label5);
            groupBox3.Font = new Font("Microsoft Sans Serif", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            groupBox3.Location = new Point(483, 517);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(568, 190);
            groupBox3.TabIndex = 6;
            groupBox3.TabStop = false;
            groupBox3.Text = "Quản lý người dùng";
            // 
            // btnThemNguoiDung
            // 
            btnThemNguoiDung.Location = new Point(435, 53);
            btnThemNguoiDung.Margin = new Padding(4, 5, 4, 5);
            btnThemNguoiDung.Name = "btnThemNguoiDung";
            btnThemNguoiDung.Size = new Size(107, 46);
            btnThemNguoiDung.TabIndex = 2;
            btnThemNguoiDung.Text = "Thêm";
            btnThemNguoiDung.UseVisualStyleBackColor = true;
            btnThemNguoiDung.Click += btnThemNguoiDung_Click;
            // 
            // txtTenNguoiDung
            // 
            txtTenNguoiDung.Location = new Point(24, 63);
            txtTenNguoiDung.Margin = new Padding(4, 5, 4, 5);
            txtTenNguoiDung.Name = "txtTenNguoiDung";
            txtTenNguoiDung.Size = new Size(383, 26);
            txtTenNguoiDung.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 34);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(199, 20);
            label5.TabIndex = 0;
            label5.Text = "Nhập tên người dùng mới:";
            // 
            // Lab02_Bai06
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1067, 867);
            Controls.Add(groupBox3);
            Controls.Add(btnChonNgauNhien);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Controls.Add(lvMonAn);
            Controls.Add(btnThoat);
            Controls.Add(groupBox2);
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            Name = "Lab02_Bai06";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Hôm Nay Ăn Gì?";
            Load += Lab02_Bai06_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picMonAn).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMonAn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picMonAn;
        private System.Windows.Forms.Button btnChonNgauNhien;
        private System.Windows.Forms.Label lblNguoiDongGop;
        private System.Windows.Forms.Label lblTenMonAnChon;
        private System.Windows.Forms.ColumnHeader colTenMonAn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtTenMonAnMoi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.TextBox txtHinhAnh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboNguoiDung;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnThemNguoiDung;
        private System.Windows.Forms.TextBox txtTenNguoiDung;
        private System.Windows.Forms.Label label5;
    }
}