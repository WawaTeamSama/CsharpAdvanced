using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Program21
{
    public partial class Form1 : Form
        
    {
        Thread t;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (t != null)
            {
                Thread.Sleep(500000);
            }
            t = new Thread(Second);

            t.IsBackground = true;
            t.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;//取消跨线程错误检测
        }
        private void Second()
        {
            for (int i = 0; i < 100000; i++)
            {
                Thread.Sleep(10);
                Random rnd1 = new Random();
                int num1 = rnd1.Next(1, 7);
                label1.Text = num1.ToString ();
                Thread.Sleep(100);
                Random rnd2 = new Random();
               int num2= rnd2.Next(1, 7);
                label2.Text = num2.ToString();
                Thread.Sleep(100);
                Random rnd3 = new Random();
                int num3 =rnd3.Next(1, 7);
                label3.Text = num3.ToString();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (t != null)
            {
                t.Abort();
            }
        }
    }
}
