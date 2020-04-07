using System;
using System.IO;
using System.Text;

namespace Program09
{
    class Program
    {
        static void Main(string[] args)
        {
           using (FileStream  fsWrite=new FileStream("new text",FileMode.OpenOrCreate ,FileAccess.Write))
            {
                var str = "覆盖";
                byte[] buffer = Encoding.UTF8.GetBytes(str);
                fsWrite.Write(buffer, 0, buffer.Length);
            }
            Console.WriteLine("文件写入成为！");
        }
    }
}
