using System;
using System.Collections.Generic;
using System.Text;

namespace Program03
{
    class Class1
    {
        static void Main(string[] args)
        {
            Int[] num = new int[] { 1, 3, 5 };
            ArraList arr = new ArraList();
            for (int i = 0; i < num.Length; i++)
            {
                arr.Add(num[i]);
            }
            arr.Insert(1, 4);
            console.Write(arr[2]);
        }
    }
}
