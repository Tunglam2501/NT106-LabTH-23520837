using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lab01
{
    public partial class Lab01_Bai08 : Form
    {
        List<string> favoriteFoods = new List<string>()
        { "Cơm tấm", "Phở", "Bún bò", "Hủ tiếu", "Gà rán" };

        Random rnd = new Random();

        public Lab01_Bai08()
        {
            InitializeComponent();
        }

        private void Lab01_Bai08_Load(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string newFood = textBox1.Text.Trim();

            if (string.IsNullOrEmpty(newFood))
            {
                MessageBox.Show("Vui lòng nhập tên món ăn để thêm vào danh sách.",
                                "Lỗi nhập liệu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
                return;
            }

            if (favoriteFoods.Any(f => f.Equals(newFood, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Món ăn '{newFood}' đã có trong danh sách.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox1.Clear();
                return;
            }

            favoriteFoods.Add(newFood);
            UpdateListBox();
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (favoriteFoods.Count == 0)
            {
                MessageBox.Show("Danh sách món ăn rỗng, vui lòng thêm món ăn trước.",
                                "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = string.Empty;
                return;
            }

            int randomIndex = rnd.Next(favoriteFoods.Count);
            textBox2.Text = favoriteFoods[randomIndex];
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn một món ăn trong danh sách để xóa.",
                                "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedFood = listBox1.SelectedItem.ToString();

            DialogResult result = MessageBox.Show(
                $"Bạn có chắc muốn xóa món '{selectedFood}' khỏi danh sách không?",
                "Xác nhận xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                favoriteFoods.Remove(selectedFood);
                UpdateListBox();

                if (textBox2.Text == selectedFood)
                    textBox2.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UpdateListBox()
        {
            listBox1.Items.Clear();
            foreach (string food in favoriteFoods)
                listBox1.Items.Add(food);
        }
    }
}
