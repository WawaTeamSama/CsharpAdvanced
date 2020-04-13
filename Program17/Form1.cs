using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            var fist = "石头";


            Play(fist);
       
        }

        private void btn_Click(object sender, EventArgs e)
        {
            var fist = "剪刀";


            Play(fist);
        }

        private void brnPeper_Click(object sender, EventArgs e)
        {
            var fist = "布";


            Play(fist);
        }
        private void Play(string fist)
        {
           
            //玩家
            player p = new player();
            var enumPlayer = p.ShowFist(fist);
            lblplayer.Text = enumPlayer.ToString();
            //电脑
            computer c = new computer();
            var enumComputer = c.Showfist();
            lblcomputer.Text = c.fist.ToString();

            var enumResult = judge.GetResult((int)enumPlayer, (int)enumComputer);
            lblresult.Text = enumResult.ToString();
        }
    }
}
