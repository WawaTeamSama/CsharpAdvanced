﻿using System;
using System.IO;

namespace Program13
{
    class Program
    {
        static void Main(string[] args)
        {
            //创建文件夹
            //Directory.CreateDirectory(@"c:\test");
            //Console.WriteLine("创建文件夹成功！");
            try {
                ////删除文件夹
                //Directory.Delete(@"c:\test");
                //Console.WriteLine("删除文件夹成功!");

                ////移动文件夹
                //Directory.Move(@"c:\test", @"c:\tee");

                ////判断某个文件夹是否存在
                if (Directory.Exists(@"c:\test"))
                {
                    for (var i = 1; i <= 100; i++)
                    {
                        Directory.CreateDirectory(@"c:\test\" + i);
                    }
                }
                //查询文件夹
                //string keyPath = "100";
                //string[] path = Directory.GetDirectories(@"c:\test");
                //foreach(var p in path)
                //{
                //    if (p.Contains(keyPath))
                //    {
                //        Console.WriteLine(p);
                //        break;
                //    }
                //}

                string[] name = Directory.GetFiles(@"c:\test");
                foreach (var p in name)
                {
                    Console.WriteLine(p);
                }
            }
            catch
            {
                Console.WriteLine("文件夹不存在");
            }
            }

    }
}
