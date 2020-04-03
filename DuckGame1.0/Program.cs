using System;
using DuckGame1._0.Duck;

namespace DuckGame1._0
{
    class Program
    {
        static void Main(string[] args)
        {
            var md = new MallardDuck();
            Console.WriteLine(md.Display() + "#" + md.Swim() + "#" + md.FlyBehavior.Fly() + "#" + md.QuackBehavior.Quack());
        }
    }
}
