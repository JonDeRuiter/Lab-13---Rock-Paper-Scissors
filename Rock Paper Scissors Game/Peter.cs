﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    class Peter : Player
    {
        
        public Peter() : base("Peter")
        {
            
        }

        public override string GenRPS(int r)
        {
            return RPS.Rock;
        }
    }
}
