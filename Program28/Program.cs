using System;

namespace Program28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要打开的文件所在路径：");
            string filePath = Console.ReadLine();
            Console.WriteLine("请输入要打开的文件名称，包含后缀名");
            string fileName = Console.ReadLine();

            BaseFile bf = Factory.GetFile(filePath, fileName);
            if (bf != null)
            {
                bf.OpenFile();

            }
        }
    }
}
