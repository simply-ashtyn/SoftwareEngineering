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
            Input.GetSpeech();
            Console.ReadKey();
            Console.Clear();

            // B2
            char[] delim = new char[] { ' ', ',', '.', '"', '+',':' };
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


            // A5

            while (number != 6)
            {
                Input.ReadChoice();
                switch (number)
                {
                    case 1:
                        Console.Clear();
                        Input.GetSpeech();
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

            //

        }
        
    }
    
}
