using System;
using System.IO;
using System.Text;

namespace Program09
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (FileStream  fsWrite=new FileStream("new text",FileMode.OpenOrCreate ,FileAccess.Write))
            // {
            //     var str = "覆盖";
            //     byte[] buffer = Encoding.UTF8.GetBytes(str);
            //     fsWrite.Write(buffer, 0, buffer.Length);
            // }
            // Console.WriteLine("文件写入成功！");

            //读取文件
            FileStream fsRead = new FileStream(@"D:\CsharpAdvanced\Program09\bin\Debug\netcoreapp3.1\new text"
               , FileMode.OpenOrCreate, FileAccess.Read);
            //表示文件大小不超过5M
            byte[] buffer = new byte[1024 * 1024 * 5];
            //读取当前文件的有效字节数
            int f = fsRead.Read(buffer, 0, buffer.Length);

            //将读出的二进制字节流转换成utf8格式的字符串
            string str = Encoding.UTF8.GetString(buffer, 0, f);

            //关闭文件流
            fsRead.Close();
            //释放占据的内存
            fsRead.Dispose();

            Console.WriteLine(str);
        }
    }
}
