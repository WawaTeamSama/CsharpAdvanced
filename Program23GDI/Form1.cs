using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Program23GDI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            //绘制直线
            //创建GDI对象
            Graphics g = this.CreateGraphics();
            //创建画笔对象
            Pen pen = new Pen(Brushes.Orange);

            //建立坐标
            Point p1 = new Point(30, 50);
            Point p2 = new Point(30, 300);

            g.DrawLine(pen, p1, p2);
        }
    }
}
