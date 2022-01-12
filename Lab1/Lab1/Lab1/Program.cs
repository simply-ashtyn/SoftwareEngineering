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
            List <string> word = Input.words.ToList();



            // A5
            string[] options = new string[] { "1. The Speech", "2. List of Words", "3. Show Histogram", "4. Search for Word", "5. Remove Word", "6. Exit" };
            while (choice != 6)
            {
                Input.ReadChoice(options);
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        Input.GetSpeech();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Input.Words();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:

                        break;
                    case 4:
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
