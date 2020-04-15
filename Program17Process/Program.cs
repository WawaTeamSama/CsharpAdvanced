using System;
using System.Diagnostics;

namespace Program17Process
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取当前程序中所有正在运行的进程
            Process[] pros = Process.GetProcesses();
            foreach(var p in pros)
            {
                
            }
        }
    }
}
