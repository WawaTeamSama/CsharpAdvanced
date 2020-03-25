using System;

namespace Program01
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person() //新的赋值方式
            {
                Name = "叶玲",
                Age = 20,
                Sex = false

            };
            if (p1.Sex)
            {
                Console.WriteLine("男");
            }
        }
        
    }
    public class Person 
    {
        public string Name { get; set; }//姓名
        public int Age { get; set; }//年龄
        public bool Sex { get; set; }//性别

    }

}
