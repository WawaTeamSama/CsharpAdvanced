using System;
using System.Collections.Generic;
using System.Text;

namespace Program06
{
    
        public class CashNormal : CashSuper
        {
            
            public override decimal AcceptCash(decimal money)
            {
                return money;
            }
        }
    
}
