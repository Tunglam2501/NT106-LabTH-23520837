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
    public partial class Lab02_Bai02 : Form
    {
        public Lab02_Bai02()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Chọn file cần mở";
            ofd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                string filePath = ofd.FileName;
                contentFileName.Text = ofd.SafeFileName.ToString();
                contentSize.Text = File.ReadAllBytes(filePath).Length.ToString();
                contentURL.Text = filePath;
                contentLineCount.Text = File.ReadAllLines(filePath).Length.ToString();
                contentWordCount.Text = File.ReadAllText(filePath).Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length.ToString();
                contentCharacterCount.Text = File.ReadAllText(filePath).Length.ToString();
                contentRichTextBox.Text = File.ReadAllText(filePath).ToString();
            }
            else
            {
                MessageBox.Show("Không đọc được file!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
