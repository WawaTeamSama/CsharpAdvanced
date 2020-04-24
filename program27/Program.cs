using System;
using System.Collections;
using System.Text.RegularExpressions;

namespace program27
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1();
            //Test2();
            //Test3();
            //Test4();
            int[] array = new int[] { 5, 16, 623, 3, 97, 12, 1, 3, 548, 0, 5, 7, 3 };
            Console.WriteLine(Test5(array));
        }
        public static int Test5(int[] array)
        {
            //5. 用方法来实现：计算两个数的最大值。 扩展：计算任意多个数间的最大值
            int Max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > Max)
                {
                    Max = array[i];
                }
            }
            return Max;
        }
        public static void Test4()
        {
            //4.请将字符串数组{ "中国", "美国", "巴西", "澳大利亚", "加拿大" }中的内容反转。然后输出反转后的数组。不能用数组的Reverse()方法
            string[] str = new string[] { "中国", "美国", "巴西", "澳大利亚", "加拿大" };
            ArrayList newstr = new ArrayList();
            string str2 = "";
            foreach (string i in str)
            {
                str2 += i;
            }
            for (int i = 1; i <= str2.Length; i++)
            {
                newstr.Add(str2.Substring(str2.Length - i, 1));
            }
            foreach (string i in newstr)
            {
                Console.Write(i);
            }
        }
        public static void Test3()
        {
            //3.存储用户输入的姓名，回车存储；只要用户不输入‘quit’就可以一直输入。
            //输入quit后打印出所有刚才输入的姓名，统计个数
            ArrayList UsernameArray = new ArrayList();
            string name = "";
            while (name != "quit")
            {
                Console.WriteLine("请输入用户的姓名（输入quit退出）");
                name = Console.ReadLine();
                UsernameArray.Add(name);
            }
            Console.Clear();
            foreach (string i in UsernameArray)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("一共个数为" + UsernameArray.Count);
        }
        public static void Test2()
        {
            //2.将字符串"  hello      world,你  好 世界   !    "
            //两端空格去掉，并且将其中的所有其他空格都替换成一个空格，
            //输出结果为："hello world,你 好 世界 !"。
            string str2 = "  hello      world,你  好 世界   !    ";
            string newstr2 = Regex.Replace(str2.Trim(), " {2,}", " ");
            Console.WriteLine(newstr2);
        }
        public static void Test1()
        {
            //1.找出第1次出现咳嗽的位置是第几个字符
            string str = "患者：“大夫，我咳嗽得很重。”大夫：“你多大年记？”患者：“七十五岁。”大夫：“二十岁咳嗽吗”患者：“不咳嗽。”大夫：“四十岁时咳嗽吗？”患者：“也不咳嗽。”大夫：“那现在不咳嗽，还要等到什么时咳嗽？";

            Console.WriteLine("咳嗽第一次出现的位置为第" + str.IndexOf("咳嗽") + "个字符");
        }
        
       
        
       
    }
}
