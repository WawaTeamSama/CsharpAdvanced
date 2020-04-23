using System;

namespace Program25
{
    class Program
    {
        static void Main(string[] args)
        {

            //用方法实现：计算1-100之间的质数和
            //质数只能被1和它本身整除
            Console.WriteLine("1-100之间的质数和为："+primeNumberSum(100));
        }
        public static int primeNumberSum(int range)//算总和
        {
            int sum = 1;
           for(int i = 1; i <= range; i++)
            {
                if (IsPrime(i))
                {
                    sum += i;
                }
            }
            return sum;
        }
        public static bool IsPrime(int n) //判断是否是质数
        {
            for(int i = 2; i <= n/2+1; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
