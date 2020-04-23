using System;

namespace Program26
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.用方法来实现：有一个字符串数组：马龙，迈克尔乔丹，雷吉米勒，蒂姆邓肯，科比布莱恩特，请输出最长的字符
        
            string[] str = new string[5] { "马龙", "迈克尔乔丹", "雷吉米勒", "蒂姆邓肯", "科比布莱恩特" };
            Console.WriteLine(GetLongestStr(str));

            //2.用方法来实现：请计算出一个整形数组的平均值 1,3,5,7,93,33,4,4,6,8,10 要求计算结果如果有小数，则显示小数点后两位（四舍五入）
            int[] nums = new int[11] { 1, 3, 5, 7, 93, 33, 4, 4, 6, 8, 10 };
            Console.WriteLine(GetAve(nums));

        }
        public static string GetLongestStr(string[] array)
        {
            string longest = "";
            for(int i = 0; i < array.Length; i++)
            {
                if (longest.Length - array[i].Length < 0)
                {
                    longest = array[i];
                }
            }
            return longest;
        }
        public static double GetAve(int[] array)
        {
            int sum = 0;
            foreach(int i in array)
            {
                sum += i;
            }
            double ave = (double)(sum / array.Length);
            double result = Math.Round(ave, 4);
            return result;
        }
       
        //3.请通过冒泡排序法对整数数组1,3,5,7,90,2,4,6,8,10实现升序排序
    }
}
