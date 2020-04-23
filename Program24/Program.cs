using System;

namespace Program24
{
    class Program
    { 
        public delegate void SayHi(string name);
        public delegate void 
        static void Main(string[] args)
        {
            Hello("张三", SayHiChinese);
            Hello("Mark", SayHiEnglish);

            string[] names = { "abcdefg", "aagsoigaj", "ehhhhhhhhhhhhhhhhhhhhh" };
            int[] nums = { 1, 2, 3, 4, 5 };
        }
        public static T GetMax<T>(T[] items,)
        {

        }
       
        public static void Hello(string name,SayHi delegateSayHi)
        {
            delegateSayHi(name);
        }
        public static void SayHiChinese(string name)
        {
            Console.WriteLine("你好"+name);
        }
        public static void SayHiEnglish(string name)
        {
            Console.WriteLine("Nice to see you" + name);
        }
    }
}
