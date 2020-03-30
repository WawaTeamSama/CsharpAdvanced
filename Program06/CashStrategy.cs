using System;
using System.Collections.Generic;
using System.Text;

namespace Program06
{
    class CashStrategy
    {
        private CashSuper cs;
        private double rebate;
        public CashStrategy(string type,double rebate = 1)
        {
            switch (type)
            {
                case "Normal":
                    this.cs = new CashNormal();
                    break;
                case "Rebate":
                    this.cs = new CashRebate(rebate);
                    break;
            }
        }
        public decimal  GetTotal(decimal money)
        {
            return cs.AcceptCash(money);
        }
    }
}
