using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CashShop;

namespace CashShop.Bussiness
{
    /// <summary>
    /// 通过此类访问折扣促销数据，定义门面Facade
    /// </summary>
    public class CashFacade
    {
        //读出xml文件内容，保存到string数组
        public string[] GetCashAcceptTypeList()
        {
            var cat = new CashAcceptType();
            var ds = cat.GetCashAcceptType();

            //把ds转换为string[]
            var count = ds.Tables[0].DefaultView.Count;
            string[] result = new string[count];

            //把ds中的每行记录的name字段的值传入数组元素
            for (var i = 0; i < count; i++)
                result[i] = ds.Tables[0].DefaultView[i]["name"].ToString();

            return result;
        }
        public decimal GetTotalPrice(string selectValue,decimal startTotalPrice)
        {
            var cat = new CashAcceptType();
            var ds = cat.GetCashAcceptType();
            var cs = new CashStrategy();
            var dataRow =((DataRow[])ds.Tables[0].Select("name="+selectValue+"" ))[0];
        }
    }
}