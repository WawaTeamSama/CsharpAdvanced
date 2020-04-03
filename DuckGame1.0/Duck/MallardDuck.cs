using System;
using System.Collections.Generic;
using System.Text;
using DuckGame1._0.Fly;
using DuckGame1._0.Quack;

namespace DuckGame1._0.Duck
{
    class MallardDuck:DuckBase
    {
        public override string Display()
        {
            return "野鸭子";
        }
        public MallardDuck()
        {
            base.FlyBehavior = new FlyWithWing();
            base.QuackBehavior = new Quack1();
        }
    }
}
