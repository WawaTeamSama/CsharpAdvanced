using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CashShop.Bussiness;

namespace CashShop
{
    public partial class Form1 : Form
    {
        private CashFacade cf = new CashFacade();

        //用于计算总价
        private decimal totalPrice = 0.00M;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //读取xml文件  绑定下拉菜单
            cbxType.DataSource = cf.GetCashAcceptTypeList();
            cbxType.SelectedIndex = 0;
        }

        private void btn_OK_Click(object sender, EventArgs e)
        {
            var total = 0.00M;
            //传值下拉选择活动和原价，计算实际收费
            total = cf.GetTotalPrice(cbxType.SelectedItem.ToString(),
                Convert.ToDecimal(txbPrice.Text) * Convert.ToDecimal(txbNum.Text));

            totalPrice += total;
            lbList.Items.Add("单价：" + txbPrice.Text + "  数量：" + txbNum.Text + "  " + cbxType.SelectedItem + "  合计：" +
                             total.ToString("C"));

            lblResult.Text = totalPrice.ToString("C");
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            totalPrice = 0.00M;
            txbNum.Text = "";
            txbPrice.Text = "";
            lbList.Items.Clear();
            lblResult.Text = "";
        }
    }
}