using System;
using System.Collections.Generic;
using System.Text;

namespace Program05
{
    class Goods //商品类
    {
        public string Name { get; set; }//商品名称

        private int Scost;   //记录原单价
        public int SCost
        {
            get => Scost;
            set => Scost = value < 0 ? 0 : value;
        }

        public int Welfare //记录优惠 1表示单价打9折 2表示总价满减 3表示第二个半价
        {
            get;set;
        }
        private double Ncost;//记现单价
        public double NCost
        {
            get => Ncost;
            set => Ncost = Welfare == 1 ? 0.9 * Scost : Scost; //如果welfare显示1 则打九折
        }
    }
}
