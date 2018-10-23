using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    class User : Player
    {
        public User(string name) : base(name)
        {
            this.name = Validator.IsName(name);
        }
        public override string GenRPS(int r)
        {
            Console.Write("Please pick: \n     1.Rock \n     2.Paper \n     3.Scissors\n (1, 2, 3) ");
            return NumChoice(Console.ReadLine());

        }
                    
        
        public string NumChoice(string input)
        {
            int x = Validator.DigitInRange(input, 3);
            switch (x)
            {
                case 1:
                    return "Rock";
                    break;
                case 2:
                    return "Paper";
                    break;
                case 3:
                    return "Scissors";
                    break;
                default:
                    Console.WriteLine("Please use 1, 2, or 3 to pick:\n     1. Rock\n     2. Paper\n     3. Scissors \n)");
                    input = NumChoice(Console.ReadLine());
                    break;
            }
            return input;

        } 
       
    }
}
