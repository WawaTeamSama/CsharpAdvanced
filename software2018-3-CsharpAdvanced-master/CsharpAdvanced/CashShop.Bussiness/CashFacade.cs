using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using CashShop.AccessDataLib;

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

        /// <summary>
        /// 用于根据商品活动的不同，计算此商品的实际收费
        /// </summary>
        /// <param name="selectValue">用户选择的活动</param>
        /// <param name="startTotalPrice">原价</param>
        /// <returns></returns>
        public decimal GetTotalPrice(string selectValue, decimal startTotalPrice)
        {
            //获取配置文件中的活动类型
            var cat = new CashAcceptType();
            var ds = cat.GetCashAcceptType();

            var cs = new CashStrategy();

            //按用户选择的活动名称，查出活动信息，主要是查出对应的class、para字段的内容
            var dataRow = ((DataRow[])ds.Tables[0].Select("name='" + selectValue + "'"))[0];

            //反射技术，根据已知的类名，读dll文件来创建对象
            //获取类名
            var classname = dataRow["class"].ToString();
            //获取参数
            object[] args = null;
            if (!string.IsNullOrEmpty(dataRow["para"].ToString()))
            {
                args = dataRow["para"].ToString().Split(',');
            }

            //Assembly.Load 读取对应的dll文件
            //CreateInstance创建dll文件中对应类的对象
            var obj = Assembly.Load("CashShop.Bussiness")
                .CreateInstance("CashShop.Bussiness." + classname, false, BindingFlags.Default, null, args, null, null);

            cs.setBehavior((CashSuper)obj);

            return cs.GetResult(startTotalPrice);
        }
    }
}