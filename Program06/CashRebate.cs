using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Program06
{
    /// <summary>
   
    /// </summary>
    public class CashRebate : CashSuper
    {
        private double _moneyRebate = 1d;

        public CashRebate(double moneyRebate)
        {
            this._moneyRebate = moneyRebate;
        }

        public override decimal AcceptCash(decimal money)
        {
            return money * (decimal)_moneyRebate;
        }
    }
}