using System;
using System.Collections.Generic;
using System.Text;

namespace CashShop.Bussiness
{
    class CashStrategy
    {
        private CashSuper cs;
        private double rebate;
        public CashStrategy(string type,double rebate = 1,decimal moneyCondition=0M,decimal moneyReturn=0M)
        {
            switch (type)
            {
                case "Normal":
                    this.cs = new CashNormal();
                    break;
                case "Rebate":
                    this.cs = new CashRebate(rebate);
                    break;
                case "Ruduce":
                    this.cs = new CashReduce(moneyCondition,moneyReturn);
                    break;
            }
        }
        public decimal  GetTotal(decimal money)
        {
            return cs.AcceptCash(money);
        }
    }
}
