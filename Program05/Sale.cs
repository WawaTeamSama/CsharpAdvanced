﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Program05
{
    class Sale //销售类
    {
        private double  cost;   //记录单价
        public double  Cost
        {
            get => cost;
            set =>cost = value < 0 ? 0 : value; 
        }
        public int quantity { get; set; } //记录数量

        private double price;//记录总价
        public double Price
        {
            get => price;
            set => price = quantity * cost;
        }
    }

}
