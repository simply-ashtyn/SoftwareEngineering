using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public static class Input
    {
       // A2
        public static int ReadInteger()
        {
            int number = 0;
            bool isAnumber = false;
            while (isAnumber == false)
            {
                Console.Write("Enter a number: ");
                string num = Console.ReadLine();
                try
                {
                    isAnumber = int.TryParse(num, out number);
                }
                catch (Exception)
                {
                    Console.WriteLine("That is not a valid input, please try again.");
                }
            }
            return number;
        }

        // A3
        public static string ReadString()
        {
            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();
            if (String.IsNullOrEmpty(choice) )
            {
                Console.WriteLine("That is not a valid input, please try again.");
            }
            return choice;
        }

        // A4

        public static void ReadChoice()
        {
            string[] options = new string[] { "1. The Speech", "2. List of Words", "3. Show Histogram", "4. Search for Word", "5. Remove Word", "6. Exit" };
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine(options[i]);
            }
            Console.Write("\nWhat would you like to do?  ");
            ReadInteger();
        }



        //C2 --- Why is it making me put an s at the end of key and value??
        public static void Histogram(Dictionary<string, int> wordCount)
        {
            foreach (var words in wordCount)
            {
                Console.Write($"{wordCount.Keys,-10}");
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Write($"{wordCount.Values,15}");
                Console.ResetColor();
            }
        }

        //C3
        public static void WordSearch(Dictionary<string,int> wordCount)
        {
            Console.Write("What word do you want to find? ");
            string search = Console.ReadLine();
            bool found = wordCount.ContainsKey(search);
            if (found)
            {
                Console.WriteLine(search);

                int searchCount = wordCount[search];
                Console.WriteLine(searchCount);
            }
            else
            {
                Console.WriteLine($"{search} not found");
            }
        }

        //C5
        public static void RemoveWord(Dictionary<string, int> wordCount)
        {
            Console.Write("What word do you want to remove?");
            ReadString();
            bool wasRemoved = wordCount.Remove(choice);
            if (wasRemoved)
            {
                Console.WriteLine($"{choice} was removed.");
            }
            else
            {
                Console.WriteLine($"{choice} not found.");
            }
        }
}

}
