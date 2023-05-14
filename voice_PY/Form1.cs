using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace voice_PY
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.WorkingDirectory = @"D:\ngu\";
            startInfo.FileName = @"D:\python\python.exe";
            startInfo.Arguments = $"test_voice.py \"{textBox1.Text}";  //truyền đc txt cần nói sang python
            startInfo.RedirectStandardOutput = true;
            startInfo.CreateNoWindow = true;
            startInfo.UseShellExecute = false;
            Process p = Process.Start(startInfo);
            p.WaitForExit();
            while (!p.StandardOutput.EndOfStream)
            {
                string fn = p.StandardOutput.ReadLine(); //tên file
                Player.URL = @"D:\ngu\" + fn;  //play fn luôn
            }
        }
    }
}
