using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab02_Bai01 bai1 = new Lab02_Bai01();
            bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab02_Bai02 bai2 = new Lab02_Bai02();
            bai2.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            Lab02_Bai03 bai03 = new Lab02_Bai03();
            bai03.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lab02_Bai07 bai07 = new Lab02_Bai07();
            bai07.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab02_Bai05 bai05 = new Lab02_Bai05();
            bai05.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab02_Bai04 bai04 = new Lab02_Bai04();
            bai04.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab02_Bai06 bai06 = new Lab02_Bai06();
            bai06.Show();
        }
    }
}
