using System;
using System.Collections.Generic;
using System.Text;

namespace Program05
{
    class Sale //销售类
    {
        private int cost;   //记录单价
        public int Cost
        {
            get => cost;
            set =>cost = value < 0 ? 0 : value; 
        }
        public int quantity { get; set; } //记录数量

        private int price;//记录总价
        public int Price
        {
            get => price;
            set => price = quantity * cost;
        }
    }

}
