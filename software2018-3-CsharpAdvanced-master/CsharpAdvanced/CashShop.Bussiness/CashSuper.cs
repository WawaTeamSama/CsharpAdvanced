using System;
using System.Collections.Generic;
using System.Text;

namespace CashShop.Bussiness
{
    /// <summary>
    /// 建立收银抽象类
    /// 不能实例化的
    /// </summary>
    public abstract class CashSuper
    {
        //计算实收金额的抽象方法
        public abstract Decimal AcceptCash(Decimal money);
    }
}