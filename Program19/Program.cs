using System;
using System.Threading;

namespace Program19
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Program thread1 = new Program();
            thread1.Method();
            //创建另一个线程来执行
            ThreadStart ts = new ThreadStart(thread1.Method);
            Thread t = new Thread(ts);
            t.Start();
        }
        public void Method()
        {
            int i = 1;
            int j = 2;
            int result = i + j;
            Console.WriteLine("线程{0},结果{1}", AppDomain.GetCurrentThreadId().ToString(), result);
        }
    }
}
