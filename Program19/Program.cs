using System;
using System.Threading;

namespace Program19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("主线程");
            Thread t = new Thread(new ThreadStart(ThreadProc));
            t.Start();
            for(var i = 0; i < 4; i++)
            {
                Console.WriteLine("主线程做别的事");
            }
            Console.WriteLine("主线程：等待threadproc执行完毕");
            //阻塞线程
            t.Join();

            for (var i = 5; i < 10; i++)
            {
                Console.WriteLine("主线程做别的事");
            } 

            //Program thread1 = new Program();
            //thread1.Method();
            ////创建另一个线程来执行
            //ThreadStart ts = new ThreadStart(thread1.Method);
            //Thread t = new Thread(ts);
            //t.Start();
        }
        public void Method()
        {
            int i = 1;
            int j = 2;
            int result = i + j;
            Console.WriteLine("线程{0},结果{1}", AppDomain.GetCurrentThreadId().ToString(), result);
        }
        private static void ThreadProc()
        {
            for(var i = 0; i < 10; i++)
            {
                Console.WriteLine(i);

            }
        }
    }
}
