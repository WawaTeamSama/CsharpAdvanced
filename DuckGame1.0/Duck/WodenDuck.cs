using System;
using System.Collections.Generic;
using System.Text;
using DuckGame1._0.Fly;
using DuckGame1._0.Quack;

namespace DuckGame1._0.Duck
{
    class WodenDuck:DuckBase
    {
        public override string Display()
        {
            return "木头鸭";
        }
        public WodenDuck()
        {
            base.FlyBehavior = new FlyNoWay();
            base.QuackBehavior = new Quack2();
        }
    }
}
