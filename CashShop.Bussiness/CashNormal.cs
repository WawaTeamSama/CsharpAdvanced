using System;
using System.Collections.Generic;
using System.Text;

namespace CashShop.Bussiness
{
    /// <summary>
    /// 实现原价收银
    /// </summary>
    public class CashNormal : CashSuper
    {
        //按原价计算总价
        public override decimal AcceptCash(decimal money)
        {
            return money;
        }
    }
}