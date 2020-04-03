using System;
using System.Collections.Generic;
using System.Text;
using DuckGame1._0.Fly;
using DuckGame1._0.Quack;

namespace DuckGame1._0.Duck
{
    public  class DuckBase
    {
        public  string Swim()
        {
            return "我会游泳";
        }
        public virtual string Display()
        {
            return "";

        }
        public IflyBehavior FlyBehavior { get; set; }
        
        public IQuackBehavior QuackBehavior { get; set; }
    }
}
