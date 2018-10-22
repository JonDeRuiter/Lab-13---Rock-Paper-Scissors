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
            Console.Write("Please pick: \n     Rock \n     Paper \n     Scissors\n");
            return Choice(Console.ReadLine());

        }

        public string Choice(string input)
        {
            input = Validator.IsABC(input);
            input = input.ToLower();
            switch (input)
            {
                case "rock":
                    return "Rock";
                    break;
                case "paper":
                    return "Paper";
                    break;
                case "scissors":
                    return "Scissors";
                    break;
                default:
                    Console.WriteLine("That was an invalid choice. \nPlease pick from \n     Rock\n     Paper\n     Scissors");
                    input = Choice(Console.ReadLine());
                    break;
            }
            return input;
            
        }
    }
}
