using System;
using System.Windows.Forms;
using System.Text; // Thêm namespace này cho StringBuilder

namespace Lab01
{
    public partial class Lab01_Bai05 : Form
    {
        public Lab01_Bai05()
        {
            InitializeComponent();
            // Khởi tạo ComboBox
            cboPhepToan.Items.Add("Bằng cứu chương: B - A");
            cboPhepToan.Items.Add("Tính toán các giá trị");
            cboPhepToan.SelectedIndex = 0; // Chọn mục đầu tiên mặc định
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            rtbKetQua.Clear(); // Xóa kết quả cũ

            // Kiểm tra và lấy giá trị A
            if (!int.TryParse(txtA.Text, out int A))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho A.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtA.Focus();
                return;
            }

            // Kiểm tra và lấy giá trị B
            if (!int.TryParse(txtB.Text, out int B))
            {
                MessageBox.Show("Vui lòng nhập số nguyên hợp lệ cho B.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtB.Focus();
                return;
            }

            // Xử lý dựa trên lựa chọn trong ComboBox
            if (cboPhepToan.SelectedIndex == 0) // Bằng cứu chương: B - A
            {
                int resultDifference = B - A;
                rtbKetQua.AppendText($"Giá trị B - A = {resultDifference}\n\n");
                rtbKetQua.AppendText(GenerateMultiplicationTable(resultDifference));
            }
            else if (cboPhepToan.SelectedIndex == 1) // Tính toán các giá trị: (A-B)! và Tổng S
            {
                // Tính (A - B)!
                try
                {
                    long factorialResult = CalculateFactorial(A - B);
                    rtbKetQua.AppendText($"{(A - B)}! = {factorialResult}\n");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi tính giai thừa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi tính giai thừa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                // Tính tổng S = A^1 + A^2 + A^3 + ... + A^B
                try
                {
                    long sumS = CalculateSumOfPowers(A, B);
                    rtbKetQua.AppendText($"Tổng S = A^1 + A^2 + ... + A^B = {sumS}\n");
                }
                catch (ArgumentException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi tính tổng lũy thừa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (OverflowException ex)
                {
                    MessageBox.Show(ex.Message, "Lỗi tính tổng lũy thừa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // Hàm tính giai thừa (không thay đổi)
        private long CalculateFactorial(int n)
        {
            if (n < 0)
            {
                throw new ArgumentException("Không thể tính giai thừa của số âm.");
            }
            if (n == 0 || n == 1)
            {
                return 1;
            }

            long result = 1;
            for (int i = 2; i <= n; i++)
            {
                if (result > long.MaxValue / i) // Kiểm tra tràn số
                {
                    throw new OverflowException($"Giá trị giai thừa của {n} quá lớn để hiển thị.");
                }
                result *= i;
            }
            return result;
        }

        // Hàm tính tổng S = A^1 + A^2 + A^3 + ... + A^B (không thay đổi)
        private long CalculateSumOfPowers(int A, int B)
        {
            if (B < 1)
            {
                throw new ArgumentException("B phải là số nguyên dương để tính tổng lũy thừa.");
            }

            long sum = 0;
            long currentPower = 1; // A^0

            for (int i = 1; i <= B; i++)
            {
                // Kiểm tra tràn số cho A^i
                if (A == 0)
                {
                    if (i == 1) currentPower = 0; else currentPower = 0;
                }
                else
                {
                    if (i == 1)
                    {
                        currentPower = A;
                    }
                    else
                    {
                        if (A != 0 && (currentPower > long.MaxValue / A || currentPower < long.MinValue / A)) // Kiểm tra tràn khi nhân
                        {
                            throw new OverflowException($"Giá trị lũy thừa A^{i} quá lớn hoặc quá nhỏ để hiển thị.");
                        }
                        currentPower *= A;
                    }
                }

                if (sum > long.MaxValue - currentPower && currentPower > 0 || sum < long.MinValue - currentPower && currentPower < 0) // Kiểm tra tràn khi cộng vào tổng
                {
                    throw new OverflowException($"Tổng S quá lớn hoặc quá nhỏ để hiển thị.");
                }
                sum += currentPower;
            }
            return sum;
        }

        // Hàm tạo bảng cửu chương (MỚI / ĐÃ SỬA ĐỔI)
        private string GenerateMultiplicationTable(int number)
        {
            if (number < 0)
            {
                return "Không có bảng cửu chương âm.";
            }
            if (number == 0)
            {
                return "Bảng cửu chương của 0:\n0 x n = 0 (với n từ 1 đến 10)";
            }

            StringBuilder sb = new StringBuilder(); // Sử dụng StringBuilder để hiệu quả hơn khi nối chuỗi
            sb.AppendLine($"Bảng cửu chương của {number}:");
            for (int i = 1; i <= 10; i++) // Bảng cửu chương thường đi từ 1 đến 10
            {
                sb.AppendLine($"{number} x {i} = {number * i}");
            }
            return sb.ToString();
        }

        // Xử lý sự kiện nút "Xóa" (không thay đổi)
        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtA.Clear();
            txtB.Clear();
            rtbKetQua.Clear();
            cboPhepToan.SelectedIndex = 0;
            txtA.Focus();
        }

        // Xử lý sự kiện nút "Thoát" (không thay đổi)
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}