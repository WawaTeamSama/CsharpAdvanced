using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace CashShop.Bussiness
{
    /// <summary>
    /// 实现原价打xx折
    /// </summary>
    public class CashRebate : CashSuper
    {
        private double _moneyRebate = 1.0d;

        public CashRebate(string moneyRebate)
        {
            this._moneyRebate = double.Parse(moneyRebate);
        }

        public override decimal AcceptCash(decimal money)
        {
            return money * (decimal)_moneyRebate;
        }
    }
}