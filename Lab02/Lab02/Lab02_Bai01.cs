using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Lab02
{
    public partial class Lab02_Bai01 : Form
    {
        public Lab02_Bai01()
        {
            InitializeComponent();
        }

        private void readButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader inputFile = new StreamReader(@"..\..\..\I_O_File\input1.txt"))
                {
                    richTextBox1.Text = inputFile.ReadToEnd();
                }
                MessageBox.Show("Đọc file thành công!");
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể đọc file!");
            }
        }

        private void writeButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamWriter outputFile = new StreamWriter(@"..\..\..\I_O_File\output1.txt"))
                {
                    string[] lines = richTextBox1.Lines;
                    foreach (var line in lines)
                    {
                        outputFile.WriteLine(line.ToUpper());
                    }
                        
                }
                MessageBox.Show("Ghi file thành công!");
            
            }
            catch (Exception)
            {
                MessageBox.Show("Không thể tìm thấy file để ghi!");
            }
        }
    }
}
