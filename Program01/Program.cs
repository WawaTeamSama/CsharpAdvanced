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
                Age = 20
               

            };
            if (p1.Sex)
            {
                Console.WriteLine("男");
            }
            Console.WriteLine(p1.NewName);
        }
        
    }
    public class Person 
    {
        public string Name { get; set; }//姓名
        public int Age { get; set; }//年龄
        public bool Sex { get; private set; } = true;//性别 给set加上private则该属性只能内部赋值 不能外部赋值

        public string NewName => $"{Name}ee"; //表达式体的属性

    }

}
