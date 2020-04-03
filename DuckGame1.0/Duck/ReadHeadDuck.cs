using System;
using System.Collections.Generic;
using System.Text;
using DuckGame1._0.Fly;
using DuckGame1._0.Quack;

namespace DuckGame1._0.Duck
{
    class ReadHeadDuck:DuckBase
    {
        public override string Display()
        {
            return "红头鸭";
        }
        public ReadHeadDuck()
        {
            base.FlyBehavior = new FlyWithWing();
            base.QuackBehavior = new Quack2();
        }
    }
}
