using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int wins, losses, ties;
            wins = 0; losses = 0; ties = 0;
            Random r = new Random();
            string wlt; //stands for "Win Loss Tie"

            Console.WriteLine("You have entered the Rock Paper Scissors Simulator");
            Console.Write("Welcome! What's your name?: ");            
            User playerOne = new User(Console.ReadLine());

            do
            {
                Player p = Opponent();

                string playerChoice = playerOne.GenRPS(1);               
                int guess = r.Next(0, 3);
                string againstChoice = p.GenRPS(guess);
                int result = RPSEval(playerChoice, againstChoice);
                if (result == 1)
                {
                    wlt = "win!";
                    wins++;
                }
                else if (result == 0)
                {
                    wlt = "tie.";
                    ties++;
                }
                else if (result == -1)
                {
                    wlt = "lose...";
                    losses++;
                }
                else
                {
                    Console.WriteLine("I don't know what you did, but it was wrong...");
                    wlt = "huh...";
                }
                Console.Clear();
                Console.WriteLine($"{playerOne.Name}, you played {playerChoice}.");
                Console.WriteLine($"{p.Name} played {againstChoice}.");
                Console.WriteLine($"You {wlt}");
                Console.WriteLine($"You have won {wins} times, lost {losses} times, and tied {ties} time(s).");


            } while (Continue());

            Console.Clear();
            Console.WriteLine($"FINAL RESULTS: \nYou won {wins} times, lost {losses} times, and tied {ties} time(s). \nGoodbye!");
            Console.ReadLine();

        }
        public static bool Continue()
        {
            bool run;
            Console.WriteLine("Play again? y/n");
            string answer = Console.ReadLine();
            answer = answer.ToLower();

            if (answer == "y")

            {
                run = true;
            }
            else if (answer == "n")
            {
                run = false;
            }
            else
            {
                Console.WriteLine("Sorry, I didn't understand that. Try again.");
                run = Continue();
            }
            return run;
        }
        public static Player Opponent()
        {
            Player p;
            Console.WriteLine("Who would you like to play agains?: \n    1. Peter \n    2. Andrew");
            int x = Validator.DigitInRange(Console.ReadLine(), 2);
            if (x == 1)
            {
                p = new Peter();
            }
            else
            {
                p = new Andrew();
            }
            
            
            return p;
        }
        public static int RPSEval(string choice, string counterchoice)
        {
            //Win returns 1, Tie returns 0, Loss returns -1

            //Grouped by player choice
            if (choice == "Rock" && counterchoice == "Paper")
            {
                return -1;
            }
            else if (choice == "Rock" && counterchoice == "Rock")
            {
                return 0;
            }
            else if (choice == "Rock" && counterchoice == "Scissors")
            {
                return 1;
            }
            else if (choice == "Paper" && counterchoice == "Paper")
            {
                return 0;
            }
            else if (choice == "Paper" && counterchoice == "Rock")
            {
                return 1;
            }
            else if (choice == "Paper" && counterchoice == "Scissors")
            {
                return -1;
            }
            else if (choice == "Scissors" && counterchoice == "Paper")
            {
                return 1;
            }
            else if (choice == "Scissors" && counterchoice == "Rock")
            {
                return -1;
            }
            else if (choice == "Scissors" && counterchoice == "Scissors")
            {
                return 0;
            }
            return 3;
        }
    }
}
