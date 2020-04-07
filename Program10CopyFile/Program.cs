using System;
using System.IO;
using System.Text;
namespace Program10CopyFile
{
    /// <summary>
    /// 实现文件的复制
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var source = "1txt";
            var target = "2txt";
            CopyFile(source, target);
            Console.WriteLine("Copy Successed!");
           
        }
        public static void CopyFile(string source,string target)
        {
            using (FileStream fsWrite = new FileStream("txt1", FileMode.OpenOrCreate, FileAccess.Write))
            {
                var str1 = source;
                byte[] buffer1 = Encoding.UTF8.GetBytes(str1);
                fsWrite.Write(buffer1, 0, buffer1.Length);
            }
            Console.WriteLine("文件写入成功！");

            FileStream fsRead = new FileStream(@"D:\CsharpAdvanced\Program10CopyFile\bin\Debug\netcoreapp3.1\txt1"
               , FileMode.OpenOrCreate, FileAccess.Read);
            //表示文件大小不超过5M
            byte[] buffer2 = new byte[1024 * 1024 * 5];
            //读取当前文件的有效字节数
            int f = fsRead.Read(buffer2, 0, buffer2.Length);

            //将读出的二进制字节流转换成utf8格式的字符串
            string str2 = Encoding.UTF8.GetString(buffer2, 0, f);

            //关闭文件流
            fsRead.Close();
            //释放占据的内存
            fsRead.Dispose();

            using (FileStream fsWrite = new FileStream("txt2", FileMode.OpenOrCreate, FileAccess.Write))
            {
                var str3 = "txt1";
                byte[] buffer3 = Encoding.UTF8.GetBytes(str3);
                fsWrite.Write(buffer3, 0, buffer3.Length);
            }
            
        }
    }
}
