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
    public partial class Lab01_Bai03 : Form
    {
        public Lab01_Bai03()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num;
            string readNum = "";

            // Sử dụng TryParse để kiểm tra và parse an toàn
            if (int.TryParse(textBox1.Text.Trim(), out num))
            {
                // Nếu là số nguyên, tiếp tục xử lý switch case
                switch (num)
                {
                    case 0:
                        readNum = "Không";
                        break;
                    case 1:
                        readNum = "Một";
                        break;
                    case 2:
                        readNum = "Hai";
                        break;
                    case 3:
                        readNum = "Ba";
                        break;
                    case 4:
                        readNum = "Bốn";
                        break;
                    case 5:
                        readNum = "Năm";
                        break;
                    case 6:
                        readNum = "Sáu";
                        break;
                    case 7:
                        readNum = "Bảy";
                        break;
                    case 8:
                        readNum = "Tám";
                        break;
                    case 9:
                        readNum = "Chín";
                        break;
                    default:
                        MessageBox.Show("Vui lòng nhập giá trị từ 0 đến 9!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        // Xóa ô hiển thị kết quả nếu có lỗi phạm vi
                        textBox2.Text = "";
                        return; // Ngừng thực thi nếu có lỗi phạm vi
                }
                textBox2.Text = readNum;
            }
            else
            {
                // Nếu không phải là số nguyên, hiển thị MessageBox
                MessageBox.Show("Vui lòng nhập một số nguyên từ 0 đến 9!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = ""; // Xóa ô hiển thị kết quả
                textBox1.Text = ""; // Xóa ô nhập liệu
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
