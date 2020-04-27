using System;

namespace Program29
{
    class Program
    {
        public delegate string DelProStr(string str);
        static void Main(string[] args)
        {
            string[] str = { "abcdDE", "DEefsEFDd", "ASFdf" };
            //大写
            ProString(str, Upper);
            foreach (string i in str)
            {
                Console.WriteLine(i);
            }
            //小写
            ProString(str, Lower);
            foreach(string i in str)
            {
                Console.WriteLine(i);
            }
        }
        static void ProString(string[] str, DelProStr delegate1)
        {
            for(int i =0;i<str.Length;i++)
            {
                str[i] = delegate1(str[i]);
            }
        }
        static string Lower(string str)
        {
            string result = "";
            result = str.ToLower();
            return result;
        }
        static string Upper(string str)
        {
            string result = "";
            result = str.ToUpper();
            return result;
        }
        static string doubleI(string str)
        {
            string result = "";
            
        }
    }
}
