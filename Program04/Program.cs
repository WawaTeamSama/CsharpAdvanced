using System;

namespace Program04
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student(name: "张三", sex: false);
            var stu = new Student(name: "张三", sex: false) { Name = "ssg", Age = 20, Sex = false };
            Console.WriteLine(stu);
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public bool Sex { get; set; }
        public int age 
        {
            get;
            set;
        }
        public int Age
        {
            get => age;
            set => age = value > 150 || value < 0 ? 0 : value;
        }
        

        public double Math { get; set; }
        public double English{ get; set; }
        public double Chinese { get; set; }
        public Student(string name,bool sex,int age,double math,double english,double chinese)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
            this.Math = math;
            this.English = english;
            this.Chinese = chinese;
        }
        public Student(string name, bool sex)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = 18;
            this.Math = 0;
            this.English = 0;
            this.Chinese = 0;
        }
        //重写tosring方法
        public override string ToString() => $"姓名:{Name}性别{Sex}年龄{Age}";
        
           
        
    }
}
