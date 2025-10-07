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
    public partial class Lab01_Bai02 : Form
    {
        public Lab01_Bai02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float num1, num2, num3;

            // Sử dụng TryParse để kiểm tra và parse
            bool parse1 = float.TryParse(textBox1.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out num1);
            bool parse2 = float.TryParse(textBox2.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out num2);
            bool parse3 = float.TryParse(textBox3.Text.Trim(), NumberStyles.Float, CultureInfo.InvariantCulture, out num3);

            if (parse1 && parse2 && parse3)
            {
                float max, min;
                max = num1 > num2 ? (num1 > num3 ? num1 : num3) : (num2 > num3 ? num2 : num3);
                min = num1 < num2 ? (num1 < num3 ? num1 : num3) : (num2 < num3 ? num2 : num3);
                textBox4.Text = max.ToString();
                textBox5.Text = min.ToString();
            }
            else
            {
                MessageBox.Show("Vui lòng nhập số thực hợp lệ vào tất cả các ô!", "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Có thể xóa các ô nhập nếu muốn
                // textBox1.Text = string.Empty;
                // textBox2.Text = string.Empty;
                // textBox3.Text = string.Empty;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
            textBox4.Text = string.Empty;
            textBox5.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
