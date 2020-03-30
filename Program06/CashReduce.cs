using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Program06
{
    /// <summary>

    /// </summary>
    public class CashReduce : CashSuper
    {
        private decimal moneyCondition = 0M;
        private decimal moneyReturn = 0.0M;

        public CashReduce(decimal moneyCondition,decimal moneyReturn)
        {
            this.moneyCondition = moneyCondition;
            this.moneyReturn = moneyReturn;
        }

        public override decimal AcceptCash(decimal money)
        {
            var totalPrice = money;
            if (money >= moneyCondition)
            {
                totalPrice = money - Math.Floor(money / moneyCondition) * moneyReturn;
            }
            return totalPrice;
        }
    }
}