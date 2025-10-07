using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai06 : Form
    {
        public Lab01_Bai06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int day, month, year;
            string zodiac = "";

            // 1. Xác thực dữ liệu nhập vào có phải là số nguyên không
            // Sử dụng TryParse để tránh lỗi FormatException nếu người dùng nhập chữ
            if (!Int32.TryParse(textBox1.Text.Trim(), out day))
            {
                MessageBox.Show("Vui lòng nhập ngày là một số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus(); // Đặt con trỏ vào ô ngày để người dùng sửa
                return; // Dừng xử lý
            }

            if (!Int32.TryParse(textBox2.Text.Trim(), out month))
            {
                MessageBox.Show("Vui lòng nhập tháng là một số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }

            // Năm không ảnh hưởng đến cung hoàng đạo, nhưng vẫn nên xác thực nếu muốn sử dụng sau này
            if (!Int32.TryParse(textBox3.Text.Trim(), out year))
            {
                MessageBox.Show("Vui lòng nhập năm là một số nguyên hợp lệ!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox3.Focus();
                return;
            }

            // 2. Xác thực tính hợp lệ của ngày và tháng
            if (month < 1 || month > 12)
            {
                MessageBox.Show("Tháng không hợp lệ! Vui lòng nhập tháng từ 1 đến 12.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Focus();
                return;
            }

            // Lấy số ngày tối đa của tháng để xác thực ngày
            int maxDay;
            switch (month)
            {
                case 2: // Tháng 2 có thể là 29 ngày nếu là năm nhuận
                    maxDay = DateTime.IsLeapYear(year) ? 29 : 28;
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    maxDay = 30;
                    break;
                default:
                    maxDay = 31;
                    break;
            }

            if (day < 1 || day > maxDay)
            {
                MessageBox.Show($"Ngày không hợp lệ! Vui lòng nhập ngày từ 1 đến {maxDay} cho tháng {month}.", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Focus();
                return;
            }

            // 3. Tính toán cung hoàng đạo (phần này giữ nguyên vì đã đúng logic)
            switch (month)
            {
                case 1: // Tháng 1
                    zodiac = day >= 21 ? "Bảo Bình" : "Ma Kết";
                    break;
                case 2: // Tháng 2
                    zodiac = day >= 20 ? "Song Ngư" : "Bảo Bình";
                    break;
                case 3: // Tháng 3
                    zodiac = day >= 21 ? "Bạch Dương" : "Song Ngư";
                    break;
                case 4: // Tháng 4
                    zodiac = day >= 21 ? "Kim Ngưu" : "Bạch Dương";
                    break;
                case 5: // Tháng 5
                    zodiac = day >= 22 ? "Song Tử" : "Kim Ngưu";
                    break;
                case 6: // Tháng 6
                    zodiac = day >= 22 ? "Cự Giải" : "Song Tử";
                    break;
                case 7: // Tháng 7
                    zodiac = day >= 23 ? "Sư Tử" : "Cự Giải";
                    break;
                case 8: // Tháng 8
                    zodiac = day >= 23 ? "Xử Nữ" : "Sư Tử";
                    break;
                case 9: // Tháng 9
                    zodiac = day >= 24 ? "Thiên Bình" : "Xử Nữ";
                    break;
                case 10: // Tháng 10
                    zodiac = day >= 24 ? "Thần Nông" : "Thiên Bình";
                    break;
                case 11: // Tháng 11
                    zodiac = day >= 23 ? "Nhân Mã" : "Thần Nông";
                    break;
                case 12: // Tháng 12
                    zodiac = day >= 22 ? "Ma Kết" : "Nhân Mã";
                    break;
            }

            // 4. Hiển thị kết quả
            textBox4.Text = zodiac;
        }
    }
}