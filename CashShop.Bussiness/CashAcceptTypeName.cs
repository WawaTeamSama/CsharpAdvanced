using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace CashShop.Bussiness
{
    /// <summary>
    /// 读取XML文件，读取当前的类型数据
    /// </summary>
    public class CashAcceptType
    {
        public DataSet GetCashAcceptType()
        {
            var ds = new DataSet();
            ds.ReadXml("CashAcceptType.xml");
            return ds;
        }
    }
}
