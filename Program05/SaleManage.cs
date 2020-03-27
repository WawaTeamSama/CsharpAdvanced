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
        private double sum { get; set; }
     
        public SaleManage() { }
        public SaleManage(string name,double cost,int quantity,int welfare)
        {
           
            sum = cost * quantity;
            goods = new Goods()
            {
                Name = name,
                NCost = cost,
                Welfare=welfare
            };
            sale = new Sale()
            {
                Cost = cost,
                quantity = quantity,
                Price = cost * quantity

            };
            if (welfare == 1)
            {
                cost *= 0.9;
                this.welfare = "此商品打九折";
                sum = cost * quantity;
            }
            
            else if(welfare == 2)
            {
                this.welfare = "此商品满100减十元";
                if (sum >= 100)
                {
                    sum -= 10;
                }
            }
            else if(welfare == 3)
            {
                this.welfare = "此商品第二件半价";
                if (quantity >= 2) 
                {
                    sum -= cost * 0.5;
                }
            }
            Math.Ceiling(sum);
        
        }
        public void Print() => Console.WriteLine($"{goods.Name}  {sale.Cost}  {sale.quantity}  {sum}  {welfare}");


    }
}
