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
using System.Text;

namespace Program18Dialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            //点击弹出对话框
            var dialogopen = new OpenFileDialog();

            //设置对话框属性
            dialogopen.Title = "请选择要打开的文件"; //标题
            dialogopen.Multiselect = true;//支持对话框可以多选
            dialogopen.InitialDirectory = @"c:\test";//默认目录
            dialogopen.Filter = "文件文件|*.txt";//默认文件

            //展开对话框
            dialogopen.ShowDialog();//展开对话框

            //获得选中文件的路径
            var paths = dialogopen.FileNames;
            if (paths.Length == 0)
            {
                MessageBox.Show("请选择一个文件！");
                return;
            }
            //读取二进制文件 并显示在文本框
            textBox1.Text = string.Empty;
            foreach(var path in paths)
            {
                using (FileStream fsRead = new FileStream(path, FileMode.OpenOrCreate, FileAccess.Read))
                {
                    byte[] buffer = new byte[1024 * 1024 * 10];
                    int r = fsRead.Read(buffer, 0, buffer.Length);
                    textBox1.Text += Encoding.UTF8.GetString(buffer, 0, r) + "\r\n\r\n";
                }
            }
           
        }
    }
}
