using System;
using System.Collections;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] num = new int[] { 1, 3, 5 };
            ArrayList arr = new ArrayList();
            for (int i = 0; i < num.Length; i++)
            {
                arr.Add(num[i]);
            }
            arr.Insert(1, 4);
            Console.Write(arr[2]);
        }
    }
}
