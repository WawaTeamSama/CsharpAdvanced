using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

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
            Pen pen = new Pen(Color.Orange,5.0f);
            //pen.DashStyle = DashStyle.Dot;
            //线条风格
            //float[] dashValues = { 2, 4, 6, 8 };
            //pen.DashPattern = dashValues;
            

            //建立坐标
            Point p1 = new Point(30, 50);
            Point p2 = new Point(30, 300);

            g.DrawLine(pen, p1, p2);
           
        }

        private void btnRect_Click(object sender, EventArgs e)
        {
            //创建GDI对象
            Graphics g = this.CreateGraphics();
            //创建画笔对象
            Pen pen = new Pen(Color.Orange, 5.0f);
            //定义矩形大小
            Size size = new Size(200, 400);
            Point startP = new Point(60, 50);

            Rectangle rect = new Rectangle(startP, size);
            g.DrawRectangle(pen, rect);
            
        }

        private void btnCrile_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //创建画笔对象
            Pen pen = new Pen(Color.Orange, 5.0f);
            g.DrawEllipse(pen, 60, 60, 200,200);
            
        }

        private void btnCuv_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            //创建画笔对象
            Pen pen = new Pen(Color.Orange, 5.0f);
            SolidBrush bush = new SolidBrush(Color.Orange);
            g.FillPie(bush, 60, 60, 200, 200, 60, 120);

           
            SolidBrush bush2 = new SolidBrush(Color.Blue);
            g.FillPie(bush2, 60, 60, 200, 200, 180, 180);

            g.DrawString("年度业绩", new Font("微软雅黑", 14, FontStyle.Regular), Brushes.Black, new PointF(60, 280));
        }
    }
}
