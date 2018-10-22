using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_Game
{
    class Validator
    {

        //Methods
        public static string NotEmpty(string input)
        {
            input = input.Trim();
            try
            {
                if (input == null || input == "")
                {
                    throw new Exception("Input is empty. ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please try again: ");
                input = NotEmpty(Console.ReadLine());
            }
            return input;
        }
        public static string IsABC(string input)
        {
            input = NotEmpty(input);
            char[] charArray = input.ToCharArray();
            try
            {
                for (int i = 0; i < input.Length; i++)
                {
                    if (!(char.IsLetter(charArray[i])))
                    {
                        throw new Exception("This value may only contain letters.");
                    }                    
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please try again: ");
                input = IsABC(Console.ReadLine());
            }
            return input;
        }
        public static string IsName(string input)
        {
            input = NotEmpty(input);
            char[] letterArray = input.ToCharArray();

            try
            {
                if (!(Char.IsUpper(letterArray[0])))
                {
                    throw new Exception("This value must start with an Uppercase letter.");
                }
                foreach (char c in letterArray)
                {
                    if (!(char.IsLetter(c)))
                    {
                        throw new Exception("This value may only contain letters");
                    }

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please try again: ");
                input = IsName(Console.ReadLine());

            }
            return input;

        }
        public static bool PvPChoice()
        {
            string input = IsABC(Console.ReadLine());
            try
            {
                input = input.ToLower();
                if (input == "peter")
                {
                    return true;
                }
                else if (input == "andrew")
                {
                    return false;
                }
                else
                {
                    throw new Exception("The only two valid inputs are Peter and Andrew");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.Write("Please try again: ");
                return PvPChoice();
                throw;
            }
        }
    }
}
