using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public static class Input
    {
        public static int ReadInteger()
        {
            Console.Write("Enter a number: ");
            string num = Console.ReadLine();
            try
            {
                bool isAnumber = int.TryParse(num,out int number);
                return number;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + "That is not a valid input, please try again.");
            }
            
        }

        public static void ReadString()
        {
            Console.WriteLine();
            string input = Console.ReadLine();
            if (String.IsNullOrEmpty(input) )
            {
                Console.WriteLine("That is not a valid input, please try again.");
            }
            Console.WriteLine(input);
        }

        private static void ReadChoice()
        {
            string[] drinks = new string[] { "wine", "beer", "water", "orange juice", "apple juice", "milk" };
            Console.WriteLine("What would you like to drink?");
        }


  
    }

}
