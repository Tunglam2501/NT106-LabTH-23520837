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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lab01_Bai01 bai1= new Lab01_Bai01();
            bai1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab01_Bai02 bai2= new Lab01_Bai02();
            bai2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab01_Bai03 bai3= new Lab01_Bai03();
            bai3.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab01_Bai04 bai4= new Lab01_Bai04();
            bai4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab01_Bai05 bai5= new Lab01_Bai05();
            bai5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab01_Bai06 bai6= new Lab01_Bai06();
            bai6.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lab01_Bai07 bai7= new Lab01_Bai07();
            bai7.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Lab01_Bai08 bai8= new Lab01_Bai08();
            bai8.Show();    
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Lab01_Bai03NC bai9= new Lab01_Bai03NC();
            bai9.Show();
        }
    }
}
