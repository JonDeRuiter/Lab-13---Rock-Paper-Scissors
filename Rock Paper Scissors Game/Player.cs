using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    abstract class Player
    {
        protected string name;
        protected string rpsValue;

        //props
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Rps
        {
            get { return rpsValue; }
            set { rpsValue = value; }
        }

        //Const
        public Player(string name)
        {
            this.name = name;
        }
        //Methods

        public abstract string GenRPS(int r);
               
    }
}
