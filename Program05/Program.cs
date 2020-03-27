using System;

namespace Program05
{
    class Program
    {
        static void Main(string[] args)
        {

            SaleManage sm1 = new SaleManage("吸尘器", 203, 2, 1);
            SaleManage sm2= new SaleManage("小米冰箱", 4500, 1, 2);
            SaleManage sm3 = new SaleManage("音箱", 700, 5, 3);
            Console.WriteLine("名称  单价  数量  总价  优惠");
            sm1.Print();
            sm3.Print();
            sm2.Print();
        }
    }
}
