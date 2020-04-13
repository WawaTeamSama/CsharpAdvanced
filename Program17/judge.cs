using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program17
{
    public enum EnumResult 
    {
        玩家胜利,
        电脑胜利,
        平局
    }
    public  enum EnumFist 
    {
        石头=1,
        剪刀,
        布
    }

    class judge
    {
        public static EnumResult GetResult(int player,int computer)
        {
            if (player == computer)
            {
                return EnumResult.平局;
            }
            else if (player - computer == -1||player-computer==2)
            {
                return EnumResult.玩家胜利;
            }
            else
            {
                return EnumResult.电脑胜利;
            }
        }
    }
}
