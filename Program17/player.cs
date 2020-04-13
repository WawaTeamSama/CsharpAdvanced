using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program17
{
   public class player
    {
       public EnumFist ShowFist(string fist)
        {
            switch (fist) 
            {
                case "石头":
                    return EnumFist.石头;
                case "剪刀":
                    return EnumFist.剪刀;
                case "布":
                    return EnumFist.布;
                default:
                    return EnumFist.石头;
            }
            
        }
    }
}
