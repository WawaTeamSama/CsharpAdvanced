using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program23GDI { 
    /// <summary>
    /// 验证码
    /// </summary>
public class ValidateCode
    {
        //创建验证码
        public static string CreateVCode(int length)
        {
            int[] randMembers = new int[length];
            int[] validateNums = new int[length];
            string validateNumberStr = "";

            //生成起始序列值
            int seekSeek = unchecked((int)DateTime.Now.Ticks);
            Random seekRand = new Random(seekSeek);
            //根据用户输入的位数去生成随机数
            int beginSeek = seekRand.Next(0, Int32.MaxValue - length * 10000);

            int[] seeks = new int[length];
            for (int i = 0; i < length; i++)
            {
                beginSeek += 10000;
                seeks[i] = beginSeek;
            }

            //生成随机数字
            for (int i = 0; i < length; i++)
            {
                Random rnd = new Random(seeks[i]);
                int pownum = 1 * (int)Math.Pow(10, length);
                randMembers[i] = rnd.Next(pownum, Int32.MaxValue);
            }

            //抽取随机数
            for (int i = 0; i < length; i++)
            {
                string numStr = randMembers[i].ToString();
                int numLength = numStr.Length;
                Random rnd = new Random();
                int numPosition = rnd.Next(0, numLength - 1);
                validateNums[i] = Int32.Parse(numStr.Substring(numPosition, 1));
            }

            //把数组转化为最后得到的字符串
            foreach (var item in validateNums)
                validateNumberStr += item.ToString();

            return validateNumberStr;
        }

        //创建验证码的图片
        public static byte[] CreateVCodePicture(string vCode)
        {
            Bitmap image = new Bitmap(95, 40);
            Graphics g = Graphics.FromImage(image);
            Random r = new Random();
            try
            {
                g.Clear(Color.White);
                
                string[] fonts = { "Arial", "微软雅黑", "黑体", "仿宋" };
                for (var i = 0; i < vCode.Length; i++) {
                    Font font = new Font(fonts[r.Next(0,4)], 20, FontStyle.Bold | FontStyle.Italic);
                    Color[] color = { Color.Crimson, Color.Blue, Color.Red };
                    SolidBrush brush = new SolidBrush(color[r.Next(0, 3)]);
                    Point p = new Point(i * 20, 0);
                    g.DrawString(vCode[i].ToString(),font,brush,p);
                }
                MemoryStream stream = new MemoryStream();
                image.Save(stream, ImageFormat.Jpeg);

                return stream.ToArray();
                for (var i = 0; i < vCode.Length; i++)
                {
                    for( i = 0; i < 40; i++)
                    {
                        Point p1 = new Point(r.Next(0, image.Width), r.Next(0, image.Height));
                        Point p2 = new Point(r.Next(0, image.Width), r.Next(0, image.Height));
                        g.DrawLine(new Pen(Brushes.Orange), p1, p2);
                    }
                }
            }
            
            finally
            {
                g.Dispose();
                image.Dispose();
            }
        }
    }
}