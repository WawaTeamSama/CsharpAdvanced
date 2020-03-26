using System;

namespace Program04
{
    class Program
    {
        static void Main(string[] args)
        {
            Student st = new Student(name: "张三", sex: false);
        }
    }
    public class Student
    {
        public string Name { get; set; }
        public bool Sex { get; set; }
        public int Age { get; set; }
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
    }
}
