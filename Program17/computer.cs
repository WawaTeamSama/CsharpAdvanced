using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program17
{
  public class computer
    {
        public EnumFist fist { get; set; }
        public EnumFist Showfist()
        {
            Random rnd = new Random();
            int i = rnd.Next(1, 4);

            switch (i)
            {
                case 1:
                    this.fist=EnumFist.石头;
                    break;
                case 2:
                    this.fist=EnumFist.剪刀;
                    break;
                case 3:
                    this.fist=EnumFist.布;
                    break;
               
            }
            return EnumFist.布;
        }
    }
}
