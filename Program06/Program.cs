using System;

namespace Program06
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal totalPrice = 0M;
            Console.WriteLine("请选择打折方式(1.原价,2.打九折,3.打八折,4.满200减20)");
            var type = Console.ReadLine();

            CashStrategy cs;
            switch (type)
            {
                case "1":
                    cs = new CashStrategy("Normal");
                    totalPrice += cs.GetTotal(100);
                    break;
                case "2":
                    cs = new CashStrategy("Rebate",0.9);
                    totalPrice += cs.GetTotal(100);
                    break;
                case "3":
                    cs = new CashStrategy("Rebate", 0.8);
                    totalPrice += cs.GetTotal(100);
                    break;
                case "4":
                    cs = new CashStrategy("Rebate", 0.8);
                    totalPrice += cs.GetTotal(100);
                    break;
                default:break;

            }
            Console.WriteLine("原价100，现价为:" + totalPrice);
            
        }
    }
}
