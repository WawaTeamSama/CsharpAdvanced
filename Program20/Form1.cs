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
using System.Threading.Tasks;

namespace Program20
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
                t.Abort();
            }
            t = new Thread(Second);

            t.IsBackground = true;
            t.Start();
          
        }
        private void Second()
        {
            for(int i = 0; i < 100000; i++)
            {
                Thread.Sleep(1000);
                textBox1.Text = i.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;//取消跨线程错误检测
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //当关闭窗体时，把后台线程关闭
            if (t != null)
            {
                t.Abort();
            }
        }
    }
}
