using System;
using System.Collections.Generic;
using System.Text;

namespace CashShop.Bussiness
{
    public class CashReturn : CashSuper
    {
        //满减的条件
        private decimal _moneyCondition = 0.0M;

        //满减后返现金额
        private decimal _moneyReturn = 0.0M;

        public CashReturn(string moneyCondition, string moneyReturn)
        {
            this._moneyCondition = decimal.Parse(moneyCondition);
            this._moneyReturn = decimal.Parse(moneyReturn);
        }

        public override decimal AcceptCash(decimal money)
        {
            var totalPrice = money;
            if (money > _moneyCondition)
                totalPrice = money - Math.Floor(money / _moneyCondition) * _moneyReturn;
            return totalPrice;
        }
    }
}