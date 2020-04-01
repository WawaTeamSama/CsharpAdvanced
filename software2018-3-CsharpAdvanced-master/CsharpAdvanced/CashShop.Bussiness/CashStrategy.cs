using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashShop.Bussiness
{
    public class CashStrategy
    {
        private CashSuper _cs;

        public void setBehavior(CashSuper cs)
        {
            this._cs = cs;
        }

        //计算最终价格
        public decimal GetResult(decimal money)
        {
            return _cs.AcceptCash(money);
        }
    }
}