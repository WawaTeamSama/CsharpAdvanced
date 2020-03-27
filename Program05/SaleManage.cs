using System;
using System.Collections.Generic;
using System.Text;

namespace Program05
{
    class SaleManage //管理类
    {
        public Sale sale { get; }
        public Goods goods { get; }

        private string welfare { get; set; }
        public SaleManage() { }
        public SaleManage(string name,double cost,int quantity,int welfare)
        {
            goods = new Goods()
            {
                Name = name,
                NCost = cost,
                Welfare=welfare
            };
            sale = new Sale()
            {
                quantity = quantity,
                Price = cost * quantity

            };
            if (welfare == 1)
            {
                goods.NCost *= 0.9;
                this.welfare = "此商品打九折";
            }
            else if(welfare == 2)
            {
                this.welfare = "此商品满100减十元";
                if (sale.Price >= 100)
                {
                    sale.Price -= 10;
                }
            }
            else if(welfare == 3)
            {
                this.welfare = "此商品第二件半价";
                if (sale.quantity >= 2) 
                {
                    sale.Price -= sale.Price * 0.5;
                }
            }
        }
        public void Print() => Console.WriteLine($"{goods}{sale}{welfare}");


    }
}
