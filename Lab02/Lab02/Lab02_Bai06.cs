using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai06 : Form
    {
        public Lab02_Bai06()
        {
            InitializeComponent();
            dbFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"Images", "MonAnDB.sqlite");
            connectionString = $"Data Source={dbFilePath};Version=3;";
        }

        private string dbFilePath;
        private string connectionString;
        private Random random = new Random();

        private void Lab02_Bai06_Load(object sender, EventArgs e)
        {
            try
            {
                Directory.CreateDirectory(Path.GetDirectoryName(dbFilePath));
                KhoiTaoCoSoDuLieu();
                TaiDanhSachMonAn();
                TaiDanhSachNguoiDung(); // Tải danh sách người dùng vào ComboBox
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Lỗi nghiêm trọng khi khởi tạo: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void KhoiTaoCoSoDuLieu()
        {
            if (!File.Exists(dbFilePath))
            {
                SQLiteConnection.CreateFile(dbFilePath);
            }

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string checkTableQuery = "SELECT name FROM sqlite_master WHERE type='table' AND name='MonAn'";
                using (var checkCmd = new SQLiteCommand(checkTableQuery, connection))
                {
                    if (checkCmd.ExecuteScalar() == null)
                    {
                        string createTablesAndData = @"
                        CREATE TABLE NguoiDung (
                            IDNCC INTEGER PRIMARY KEY AUTOINCREMENT,
                            HoVaTen TEXT NOT NULL,
                            QuyenHan TEXT
                        );

                        CREATE TABLE MonAn (
                            IDMA INTEGER PRIMARY KEY AUTOINCREMENT,
                            TenMonAn TEXT NOT NULL,
                            HinhAnh TEXT,
                            IDNCC INTEGER,
                            FOREIGN KEY(IDNCC) REFERENCES NguoiDung(IDNCC)
                        );

                        INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES ('Nguyễn Văn A', 'Admin');
                        INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES ('Trần Thị B', 'User');

                        INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES ('Phở Bò', 'phobo.png', 1);
                        INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES ('Bún Chả', 'buncha.png', 1);
                        INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES ('Cơm Tấm', 'comtam.png', 2);
                        INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES ('Bánh Mì', 'banhmi.png', 2);
                        ";
                        using (var command = new SQLiteCommand(createTablesAndData, connection))
                        {
                            command.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        private void TaiDanhSachMonAn()
        {
            lvMonAn.Items.Clear();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT IDMA, TenMonAn FROM MonAn";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListViewItem item = new ListViewItem(reader["TenMonAn"].ToString());
                            item.Tag = Convert.ToInt32(reader["IDMA"]);
                            lvMonAn.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void TaiDanhSachNguoiDung()
        {
            cboNguoiDung.Items.Clear();
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT IDNCC, HoVaTen FROM NguoiDung ORDER BY HoVaTen";
                using (var command = new SQLiteCommand(query, connection))
                {
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            // Tạo đối tượng để lưu cả ID và Tên
                            var nguoiDung = new NguoiDungItem
                            {
                                IDNCC = Convert.ToInt32(reader["IDNCC"]),
                                HoVaTen = reader["HoVaTen"].ToString()
                            };
                            cboNguoiDung.Items.Add(nguoiDung);
                        }
                    }
                }
            }

            // Chọn người dùng đầu tiên nếu có
            if (cboNguoiDung.Items.Count > 0)
            {
                cboNguoiDung.SelectedIndex = 0;
            }
        }

        private void btnChonNgauNhien_Click(object sender, EventArgs e)
        {
            if (lvMonAn.Items.Count == 0)
            {
                MessageBox.Show("Không có món ăn nào trong danh sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int randomIndex = random.Next(0, lvMonAn.Items.Count);
            int selectedId = Convert.ToInt32(lvMonAn.Items[randomIndex].Tag);

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"
                SELECT MA.TenMonAn, MA.HinhAnh, ND.HoVaTen 
                FROM MonAn MA
                JOIN NguoiDung ND ON MA.IDNCC = ND.IDNCC
                WHERE MA.IDMA = @id";

                using (var command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", selectedId);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            lblTenMonAnChon.Text = reader["TenMonAn"].ToString();
                            lblNguoiDongGop.Text = reader["HoVaTen"].ToString();
                            string imageName = reader["HinhAnh"].ToString();
                            string imagePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", imageName);

                            try
                            {
                                if (!string.IsNullOrEmpty(imageName) && File.Exists(imagePath))
                                {
                                    picMonAn.Image = Image.FromFile(imagePath);
                                }
                                else
                                {
                                    picMonAn.Image = null;
                                    MessageBox.Show($"Không tìm thấy hình ảnh: {imageName}", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            catch (Exception ex)
                            {
                                picMonAn.Image = null;
                                MessageBox.Show("Lỗi khi tải hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string tenMonAnMoi = txtTenMonAnMoi.Text.Trim();
            string hinhAnh = txtHinhAnh.Text.Trim();

            if (string.IsNullOrEmpty(tenMonAnMoi))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenMonAnMoi.Focus();
                return;
            }

            if (cboNguoiDung.SelectedItem == null)
            {
                MessageBox.Show("Vui lòng chọn người đóng góp!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cboNguoiDung.Focus();
                return;
            }

            // Lấy ID người dùng từ ComboBox
            int idNcc = ((NguoiDungItem)cboNguoiDung.SelectedItem).IDNCC;

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Kiểm tra trùng tên món ăn (không phân biệt hoa/thường và loại bỏ khoảng trắng thừa)
                    string checkQuery = @"SELECT COUNT(*) FROM MonAn 
                                  WHERE TRIM(LOWER(TenMonAn)) = TRIM(LOWER(@TenMonAn))";

                    using (var checkCmd = new SQLiteCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@TenMonAn", tenMonAnMoi);
                        long count = (long)checkCmd.ExecuteScalar();

                        if (count > 0)
                        {
                            MessageBox.Show($"Món ăn '{tenMonAnMoi}' đã có trong danh sách!",
                                            "Thông báo",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Warning);
                            txtTenMonAnMoi.Focus();
                            txtTenMonAnMoi.SelectAll();
                            return;
                        }
                    }

                    // Thêm món ăn mới
                    string insertQuery = "INSERT INTO MonAn (TenMonAn, HinhAnh, IDNCC) VALUES (@TenMonAn, @HinhAnh, @IDNCC)";
                    using (var insertCmd = new SQLiteCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@TenMonAn", tenMonAnMoi);
                        insertCmd.Parameters.AddWithValue("@HinhAnh", hinhAnh);
                        insertCmd.Parameters.AddWithValue("@IDNCC", idNcc);
                        insertCmd.ExecuteNonQuery();
                    }
                }

                TaiDanhSachMonAn();
                txtTenMonAnMoi.Clear();
                txtHinhAnh.Clear();
                txtTenMonAnMoi.Focus();

                MessageBox.Show("Thêm món ăn thành công!",
                                "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm món ăn: " + ex.Message,
                                "Lỗi CSDL",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (lvMonAn.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một món ăn trong danh sách để xóa.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            ListViewItem selectedItem = lvMonAn.SelectedItems[0];
            string idMonAn = selectedItem.Tag.ToString();
            string tenMonAn = selectedItem.Text;

            DialogResult result = MessageBox.Show($"Bạn có chắc muốn xóa món '{tenMonAn}' không?", "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM MonAn WHERE IDMA = @IDMA";
                        using (var command = new SQLiteCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@IDMA", idMonAn);
                            command.ExecuteNonQuery();
                        }
                    }

                    TaiDanhSachMonAn();

                    if (lblTenMonAnChon.Text == tenMonAn)
                    {
                        lblTenMonAnChon.Text = "Hãy chọn một món ăn!";
                        lblNguoiDongGop.Text = "Người đóng góp...";
                        picMonAn.Image = null;
                    }

                    MessageBox.Show("Xóa món ăn thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa món ăn: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnThemNguoiDung_Click(object sender, EventArgs e)
        {
            string hoVaTen = txtTenNguoiDung.Text.Trim();

            if (string.IsNullOrEmpty(hoVaTen))
            {
                MessageBox.Show("Vui lòng nhập tên người dùng!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTenNguoiDung.Focus();
                return;
            }

            try
            {
                using (var connection = new SQLiteConnection(connectionString))
                {
                    connection.Open();

                    // Kiểm tra trùng tên
                    string checkQuery = "SELECT COUNT(*) FROM NguoiDung WHERE HoVaTen = @HoVaTen COLLATE NOCASE";
                    using (var checkCmd = new SQLiteCommand(checkQuery, connection))
                    {
                        checkCmd.Parameters.AddWithValue("@HoVaTen", hoVaTen);
                        if ((long)checkCmd.ExecuteScalar() > 0)
                        {
                            MessageBox.Show($"Người dùng '{hoVaTen}' đã tồn tại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return;
                        }
                    }

                    // Thêm người dùng mới
                    string insertQuery = "INSERT INTO NguoiDung (HoVaTen, QuyenHan) VALUES (@HoVaTen, @QuyenHan)";
                    using (var insertCmd = new SQLiteCommand(insertQuery, connection))
                    {
                        insertCmd.Parameters.AddWithValue("@HoVaTen", hoVaTen);
                        insertCmd.Parameters.AddWithValue("@QuyenHan", "User"); // Mặc định là User
                        insertCmd.ExecuteNonQuery();
                    }
                }

                TaiDanhSachNguoiDung();
                txtTenNguoiDung.Clear();

                // Chọn người dùng vừa thêm
                for (int i = 0; i < cboNguoiDung.Items.Count; i++)
                {
                    if (((NguoiDungItem)cboNguoiDung.Items[i]).HoVaTen == hoVaTen)
                    {
                        cboNguoiDung.SelectedIndex = i;
                        break;
                    }
                }

                MessageBox.Show("Thêm người dùng thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm người dùng: " + ex.Message, "Lỗi CSDL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private class NguoiDungItem
        {
            public int IDNCC { get; set; }
            public string HoVaTen { get; set; }

            public override string ToString()
            {
                return HoVaTen; 
            }
        }
    }
}