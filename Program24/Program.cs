using System;

namespace Program24
{
    class Program
    { 
        public delegate void SayHi(string name);
        public delegate int DelegateCompare<T>(T t1, T t2);
        static void Main(string[] args)
        {
            Hello("张三", SayHiChinese);
            Hello("Mark", SayHiEnglish);

            string[] names = { "abcdefg", "aagsoigaj", "ehhhhhhhhhhhhhhhhhhhhh" };
            string namesMax = GetMax<string>(names, Compare2);
            Console.WriteLine(namesMax);

            int[] nums = { 1, 2, 3, 4, 5 };
            int numsMax = GetMax<int>(nums, Compare1);
            Console.WriteLine(numsMax);
        }
        public static T GetMax<T>(T[] items,DelegateCompare<T> del)
        {
            T max = items[0];
            for(var i = 0; i < items.Length; i++)
            {
                if (del(max, items[i]) < 0)
                {
                    max = items[i];
                }
            }
            return max;
        }
       
        public static int Compare1 (int n1,int n2)
        {
            return n1 - n2;
        }
        public static int Compare2(string s1,string s2)
        {
            return s1.Length - s2.Length;
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
