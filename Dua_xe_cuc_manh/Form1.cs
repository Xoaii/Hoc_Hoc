using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Dua_xe_cuc_manh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rd = new Random();
            pictureBox1.Left += rd.Next(1, 10);//biến Numrd sẽ nhận có giá trị ngẫu nhiên trong khoảng 1 đến 100
            //Chuyển giá trị ramdon về kiểu string
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
