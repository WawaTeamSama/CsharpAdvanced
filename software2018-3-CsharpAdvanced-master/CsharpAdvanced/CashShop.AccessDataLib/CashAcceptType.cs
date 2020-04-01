using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CashShop.AccessDataLib
{
    /// <summary>
    /// 读取XML文件，读取当前的折扣类型数据
    /// </summary>
    public class CashAcceptType
    {
        //读XML文件到Dataset
        public DataSet GetCashAcceptType()
        {
            var ds = new DataSet();
            ds.ReadXml("CashAcceptType.xml");
            return ds;
        }
    }
}