using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai07 : Form
    {
        public Lab01_Bai07()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Xóa nội dung cũ trong textBox2 mỗi khi nhấn nút
            textBox2.Text = "";

            // Lấy chuỗi nhập từ textBox1
            string input = textBox1.Text.Trim();

            // Kiểm tra xem input có rỗng không
            if (string.IsNullOrEmpty(input))
            {
                MessageBox.Show("Vui lòng nhập thông tin (ví dụ: Tên,điểm1,điểm2,...)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            string[] parts = input.Split(',');

            // Kiểm tra xem có đủ ít nhất tên và 1 điểm không
            if (parts.Length < 2)
            {
                MessageBox.Show("Format không hợp lệ. Vui lòng nhập ít nhất tên và một điểm số (ví dụ: Tên,điểm1)!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            // Lấy tên
            string name = parts[0].Trim();

            // Xác thực tên: không được rỗng và không được là số
            if (string.IsNullOrEmpty(name) || double.TryParse(name, out _))
            {
                MessageBox.Show("Tên không hợp lệ. Vui lòng nhập tên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            // Lấy danh sách điểm số
            List<float> scoresList = new List<float>();
            bool hasInvalidScore = false;

            for (int i = 1; i < parts.Length; i++)
            {
                string scoreStr = parts[i].Trim();
                if (!float.TryParse(scoreStr, NumberStyles.Float, CultureInfo.InvariantCulture, out float score))
                {
                    MessageBox.Show($"Điểm số '{scoreStr}' không hợp lệ. Vui lòng nhập các điểm số là số thực!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    hasInvalidScore = true;
                    break;
                }
                // Thêm xác thực điểm số nằm trong khoảng hợp lệ (ví dụ: từ 0 đến 10)
                if (score < 0 || score > 10)
                {
                    MessageBox.Show($"Điểm số '{scoreStr}' không hợp lệ. Vui lòng nhập điểm số từ 0 đến 10!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Focus();
                    hasInvalidScore = true;
                    break;
                }
                scoresList.Add(score);
            }

            if (hasInvalidScore)
            {
                return; // Dừng xử lý nếu có điểm không hợp lệ
            }

            // Chuyển List sang mảng để dễ sử dụng các phương thức Linq
            float[] scores = scoresList.ToArray();

            // Nếu không có điểm nào được nhập sau tên
            if (scores.Length == 0)
            {
                MessageBox.Show("Vui lòng nhập ít nhất một điểm số!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            // Tính toán và hiển thị kết quả
            float totalScore = scores.Sum(); // Dùng Linq Sum()
            float averageScore = totalScore / scores.Length;
            float minScore = scores.Min();
            float maxScore = scores.Max();
            int passCount = scores.Count(s => s >= 5); // Dùng Linq Count()
            int failCount = scores.Length - passCount;

            string grade = "";
            if (averageScore >= 8 && minScore >= 6.5)
                grade = "Giỏi";
            else if (averageScore >= 6.5 && minScore >= 5)
                grade = "Khá";
            else if (averageScore >= 5 && minScore >= 3.5)
                grade = "Trung bình";
            else if (averageScore >= 3.5 && minScore >= 2)
                grade = "Yếu";
            else
                grade = "Kém";

            // Hiển thị kết quả vào textBox2
            StringBuilder resultBuilder = new StringBuilder();
            resultBuilder.AppendLine($"Họ và tên: {name}");
            for (int i = 0; i < scores.Length; i++)
            {
                resultBuilder.AppendLine($"Điểm {i + 1}: {scores[i]:F2}"); // Định dạng 2 chữ số thập phân
            }
            resultBuilder.AppendLine($"Điểm trung bình: {averageScore:F2}");
            resultBuilder.AppendLine($"Điểm cao nhất: {maxScore:F2}");
            resultBuilder.AppendLine($"Điểm thấp nhất: {minScore:F2}");
            resultBuilder.AppendLine($"Số môn đậu: {passCount}");
            resultBuilder.AppendLine($"Số môn không đậu: {failCount}");
            resultBuilder.AppendLine($"Xếp loại: {grade}");

            textBox2.Text = resultBuilder.ToString();
        }
    }
}