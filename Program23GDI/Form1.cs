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
using System.Threading;
using System.IO;

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
        private void Line(int n1,int n2,int n3,int n4)
        {
            //创建GDI对象
            Graphics g = this.CreateGraphics();
            //创建画笔对象
            Pen pen = new Pen(Color.Orange, 1.0f);
            //pen.DashStyle = DashStyle.Dot;



            //建立坐标
            Point p1 = new Point(n1, n2);
            Point p2 = new Point(n3, n4);

            g.DrawLine(pen, p1, p2);
        }
        private void Dot(int n1,int n2,int n3,int n4)
        {
            //创建GDI对象
            Graphics g = this.CreateGraphics();
            //创建画笔对象
            Pen pen = new Pen(Color.Red, 1.0f);
            pen.DashStyle = DashStyle.Dot;



            //建立坐标
            Point p1 = new Point(n1, n2);
            Point p2 = new Point(n3, n4);

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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            //btnCuv.Text = "绘制图形";
            //btnLine.Text = "绘制图形";
            //btnRect.Text = "绘制图形";
            //btnCrile.Text = "绘制图形";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            for (int i = 0; i < 50; i++)
            {
                Random rnd1 = new Random();
                int n1 = rnd1.Next(30, 200);
                Thread.Sleep(n1);
                Random rnd2 = new Random();
                int n2 = rnd2.Next(30, 200);
                Thread.Sleep(n2);
                if (i == 38)
                {
                    g.DrawString("8", new Font("微软雅黑", 20, FontStyle.Regular), Brushes.Blue, new PointF(120, 55));
                }
                Random rnd3 = new Random();
                int n3 = rnd3.Next(30, 200);
                Thread.Sleep(n3);
                if (i == 24)
                {
                    g.DrawString("9", new Font("微软雅黑", 20, FontStyle.Regular), Brushes.Black, new PointF(65, 160));
                }
                Random rnd4 = new Random();
                int n4 = rnd4.Next(30, 200);
                if (i == 2)
                {
                    g.DrawString("4", new Font("微软雅黑", 20, FontStyle.Regular), Brushes.Green, new PointF(85, 90));
                }
                Thread.Sleep(n4);
                Line(n1, n2, n3, n4);
            }
            for(int i = 0; i < 10; i++)
            {
                Random rnd1 = new Random();
                int n1 = rnd1.Next(30, 200);
                Thread.Sleep(n1);
                Random rnd2 = new Random();
                int n2 = rnd2.Next(30, 200);
                Thread.Sleep(n2);
                Random rnd3 = new Random();
                int n3 = rnd3.Next(30, 200);
                Thread.Sleep(n3);
                Random rnd4 = new Random();
                int n4 = rnd4.Next(30, 200);
                Thread.Sleep(n4);
                Dot(n1, n2, n3, n4);
            }
           
           
           
            

        }

        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = ValidateCode.CreateVCode(4);
            MemoryStream ms = new MemoryStream();
            ms.Write(ValidateCode.CreateVCodePicture(label1.Text), 0, ValidateCode.CreateVCodePicture(label1.Text).Length);
            pictureBox1.Image = Image.FromStream(ms);
        }
    }
}
