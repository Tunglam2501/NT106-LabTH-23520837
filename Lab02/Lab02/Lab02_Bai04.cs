using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Lab02_Bai04 : Form
    {
        private List<SinhVien> danhSachSinhVien;
        private int currentPage = 0;
        private const int itemsPerPage = 1;
        private bool hasWrittenToFile = false;

        public Lab02_Bai04()
        {
            InitializeComponent();
            danhSachSinhVien = new List<SinhVien>();
            UpdatePageDisplay();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate inputs
                if (string.IsNullOrWhiteSpace(txtName.Text))
                {
                    MessageBox.Show("Vui lòng nhập họ tên sinh viên!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txtID.Text, out int mssv) || txtID.Text.Length != 8)
                {
                    MessageBox.Show("MSSV phải là số có 8 chữ số!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (txtPhone.Text.Length != 10 || !txtPhone.Text.StartsWith("0") ||
                    !txtPhone.Text.All(char.IsDigit))
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0!",
                        "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txtCourse1.Text, out float diem1) || diem1 < 0 || diem1 > 10)
                {
                    MessageBox.Show("Điểm môn 1 phải từ 0 đến 10!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txtCourse2.Text, out float diem2) || diem2 < 0 || diem2 > 10)
                {
                    MessageBox.Show("Điểm môn 2 phải từ 0 đến 10!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!float.TryParse(txtCourse3.Text, out float diem3) || diem3 < 0 || diem3 > 10)
                {
                    MessageBox.Show("Điểm môn 3 phải từ 0 đến 10!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Create new student
                SinhVien sv = new SinhVien
                {
                    HoTen = txtName.Text,
                    MSSV = mssv,
                    DienThoai = txtPhone.Text,
                    DiemMon1 = diem1,
                    DiemMon2 = diem2,
                    DiemMon3 = diem3,
                    DiemTrungBinh = 0
                };

                danhSachSinhVien.Add(sv);

                // Reset cờ khi có dữ liệu mới
                hasWrittenToFile = false;

                // Hiển thị danh sách đã thêm ở giữa
                UpdateFileContentDisplay();

                ClearInputs();

                MessageBox.Show("Thêm sinh viên thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (danhSachSinhVien.Count == 0)
                {
                    MessageBox.Show("Chưa có sinh viên nào để ghi!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string json = JsonSerializer.Serialize(danhSachSinhVien, new JsonSerializerOptions
                {
                    WriteIndented = true,
                    Encoder = System.Text.Encodings.Web.JavaScriptEncoder.UnsafeRelaxedJsonEscaping
                });

                File.WriteAllText(@"..\..\..\I_O_File\input4.txt", json);

                // Đánh dấu đã ghi file
                hasWrittenToFile = true;

                MessageBox.Show("Ghi file input4.txt thành công!", "Thông báo",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi file: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadFile_Click(object sender, EventArgs e)
        {
            try
            {
                // Kiểm tra đã write file chưa
                if (danhSachSinhVien.Count > 0 && !hasWrittenToFile)
                {
                    MessageBox.Show("Bạn phải ghi file trước khi đọc!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!File.Exists(@"..\..\..\I_O_File\input4.txt"))
                {
                    MessageBox.Show("File input4.txt không tồn tại!", "Thông báo",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string json = File.ReadAllText(@"..\..\..\I_O_File\input4.txt");
                List<SinhVien> danhSach = JsonSerializer.Deserialize<List<SinhVien>>(json);
                if (danhSach == null)
                {
                    MessageBox.Show("File không hợp lệ!", "Lỗi",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Tính điểm trung bình cho từng sinh viên
                foreach (var sv in danhSach)
                {
                    sv.DiemTrungBinh = (sv.DiemMon1 + sv.DiemMon2 + sv.DiemMon3) / 3;
                }

                StringBuilder sb = new StringBuilder();
                sb.AppendLine("DANH SÁCH SINH VIÊN VÀ ĐIỂM TRUNG BÌNH");
                sb.AppendLine("========================================");
                sb.AppendLine();

                for (int i = 0; i < danhSach.Count; i++)
                {
                    var sv = danhSach[i];
                    sb.AppendLine($"Sinh viên {i + 1}:");
                    sb.AppendLine($"  Họ tên: {sv.HoTen}");
                    sb.AppendLine($"  MSSV: {sv.MSSV}");
                    sb.AppendLine($"  Điện thoại: {sv.DienThoai}");
                    sb.AppendLine($"  Điểm môn 1: {sv.DiemMon1:F1}");
                    sb.AppendLine($"  Điểm môn 2: {sv.DiemMon2:F1}");
                    sb.AppendLine($"  Điểm môn 3: {sv.DiemMon3:F1}");
                    sb.AppendLine($"  Điểm trung bình: {sv.DiemTrungBinh:F2}");
                    sb.AppendLine();
                }

                File.WriteAllText(@"..\..\..\I_O_File\output4.txt", sb.ToString());

                // Hiển thị lên màn hình bên phải
                danhSachSinhVien = danhSach;
                currentPage = 0;
                DisplayCurrentStudent();

                MessageBox.Show("Đọc file và tính điểm trung bình thành công!\nĐã ghi vào output4.txt",
                    "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi đọc file: " + ex.Message, "Lỗi",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (currentPage < danhSachSinhVien.Count - 1)
            {
                currentPage++;
                DisplayCurrentStudent();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (currentPage > 0)
            {
                currentPage--;
                DisplayCurrentStudent();
            }
        }

        private void DisplayCurrentStudent()
        {
            if (danhSachSinhVien.Count == 0)
            {
                ClearDisplay();
                lblPage.Text = "0";
                return;
            }

            if (currentPage >= 0 && currentPage < danhSachSinhVien.Count)
            {
                SinhVien sv = danhSachSinhVien[currentPage];
                txtDisplayName.Text = sv.HoTen;
                txtDisplayID.Text = sv.MSSV.ToString();
                txtDisplayPhone.Text = sv.DienThoai;
                txtDisplayCourse1.Text = sv.DiemMon1.ToString("F1");
                txtDisplayCourse2.Text = sv.DiemMon2.ToString("F1");
                txtDisplayCourse3.Text = sv.DiemMon3.ToString("F1");
                txtDisplayAverage.Text = sv.DiemTrungBinh.ToString("F2");
            }

            UpdatePageDisplay();
        }

        private void UpdatePageDisplay()
        {
            if (danhSachSinhVien.Count == 0)
            {
                lblPage.Text = "0";
                btnBack.Enabled = false;
                btnNext.Enabled = false;
            }
            else
            {
                lblPage.Text = (currentPage + 1).ToString();
                btnBack.Enabled = currentPage > 0;
                btnNext.Enabled = currentPage < danhSachSinhVien.Count - 1;
            }
        }

        private void ClearInputs()
        {
            txtName.Clear();
            txtID.Clear();
            txtPhone.Clear();
            txtCourse1.Clear();
            txtCourse2.Clear();
            txtCourse3.Clear();
        }

        private void ClearDisplay()
        {
            txtDisplayName.Clear();
            txtDisplayID.Clear();
            txtDisplayPhone.Clear();
            txtDisplayCourse1.Clear();
            txtDisplayCourse2.Clear();
            txtDisplayCourse3.Clear();
            txtDisplayAverage.Clear();
        }

        private void UpdateFileContentDisplay()
        {
            // Hiển thị danh sách sinh viên hiện tại dưới dạng text
            if (danhSachSinhVien.Count == 0)
            {
                txtFileContent.Clear();
                return;
            }

            StringBuilder sb = new StringBuilder();
            foreach (var sv in danhSachSinhVien)
            {
                sb.AppendLine(sv.HoTen);
                sb.AppendLine(sv.MSSV.ToString());
                sb.AppendLine(sv.DienThoai);
                sb.AppendLine(sv.DiemMon1.ToString());
                sb.AppendLine(sv.DiemMon2.ToString());
                sb.AppendLine(sv.DiemMon3.ToString());
                sb.AppendLine();
            }
            txtFileContent.Text = sb.ToString();
        }
    }

    public class SinhVien
    {
        public string HoTen { get; set; }
        public int MSSV { get; set; }
        public string DienThoai { get; set; }
        public float DiemMon1 { get; set; }
        public float DiemMon2 { get; set; }
        public float DiemMon3 { get; set; }
        public float DiemTrungBinh { get; set; }
    }
}