using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            // B1
            string text = Input.GetSpeech();

            string[] options = new string[] { "1. The Speech", "2. List of Words", "3. Show Histogram", "4. Search for Word", "5. Remove Word", "6. Exit" };

            // B2
            char[] delim = new char[] { ' ', ',', '.', '"', '+', ':' };
            string[] words = text.Split(delim, StringSplitOptions.RemoveEmptyEntries);
            List<string> word = words.ToList();

            //C1

            Dictionary<string, int> wordCount = new Dictionary<string, int>()
            {
            };
            foreach (string item in word)
            {
                if (wordCount.ContainsKey(item))
                {
                    wordCount[item]++;
                }
                else
                {
                    wordCount.Add(item, 1);
                }
            }
            string prompt = "What would you like to do? (enter a number) ";

            // A5
            // string prompt, string [] options, out int selection

            int selection = 1;
            Input.ReadChoice(prompt, options, out selection);

            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {


                switch (selection)
                {
                    case 1:
                        Console.Clear();
                        Console.Write(text);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine(word);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Console.Clear();
                        Input.Histogram(wordCount);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 4:
                        Console.Clear();
                        Input.WordSearch(wordCount);
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }

            }

            Console.ReadKey();

        }

    }

}
