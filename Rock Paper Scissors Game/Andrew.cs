using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    class Andrew : Player
    {
        public Andrew() : base("Andrew")
        {

        }

        public override string GenRPS(int r)
        {
            {
                switch (r)
                {
                    case 0:
                        return RPS.Paper;
                        break;
                    case 1:
                        return RPS.Rock;
                        break;
                    case 2:
                        return RPS.Scisors;
                        break;
                    default:
                        break;
                }
                return "";
            }
        }
    }
}
