using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Part 1
            string[] options = new string[] { "1. Bubble Sort", "2. Merge Sort", "3. Binary Search", "4. Save", "5. Exit" };
            string prompt = "What would you like to do?";
            string fPath = "inputFile.csv";
            List<string> tList = ReadFile(fPath);
            List<string> sortedList = tList.ToString();

            int number;
            Console.WriteLine("Menu");
            Console.WriteLine("------------------------------");
            do
            {
                number = ReadChoice(prompt, options, out number);
                if (number == 1)
                {
                    BubbleSort(tList);
                }
                else if (number == 2)
                {
                    MergeSort(tList);
                }
                else if (number == 3)
                {
                    BinarySearch(sortedList, 1, sortedList.Count - 1);
                }
                else if (number == 4)
                {
                    Save(fPath);
                }
                else
                {
                    Console.WriteLine("Press any key to exit.");
                }

            } while (number != 5);


        }
        // something wrong with storing new value for number
        public static int ReadInteger(string prompt, int min, int max)
        {
            Console.WriteLine(prompt);
            int number = 0;
            bool isAnumber = false;
            bool valid = true;
            while (!valid)
            {
                string num = Console.ReadLine();
                isAnumber = int.TryParse(num, out number);
                if (isAnumber == true)
                {
                    try
                    {
                        if (number >= min && number <= max)
                        {

                            valid = true;
                        }

                    }
                    catch (Exception)
                    {
                        Console.WriteLine("That is not a valid input, please try again.");
                    }
                }
                else
                {
                    Console.WriteLine("That is not a valid input, please try again.");
                }
            }
            return number;
        }

        public static string ReadString(string prompt, ref string choice)
        {
            Console.WriteLine(prompt);
            while (true)
            {
                choice = Console.ReadLine();
                if (String.IsNullOrEmpty(choice))
                {
                    Console.WriteLine("That is not a valid input, please try again.");
                }
                break;
            }
            return choice;
        }

        public static int ReadChoice(string prompt, string[] options, out int selection)
        {
            for (int i = 0; i < options.Length; i++)
            {
                Console.WriteLine(options[i]);
            }
            selection = ReadInteger(prompt, 1, options.Length);
            return selection;
        }

        // Part 2
        static List<string> ReadFile(string fPath)
        {
            List<string> titles = new List<string>();
            using (StreamReader sr = new StreamReader(fPath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] input = line.Split(',');
                    foreach (string item in input)
                    {
                        titles.Add(item);
                    }
                }
            }
            return titles;
        }

        // Part 3

        static void BubbleSort(List<string> items)
        {
            bool swapped = false;
            for (int i = 1; i <= items.Count - 1; i++)
            {
                do
                {
                    int value = items[i - 1].CompareTo(items[i]);
                    if (value == 1 || value == -1)
                    {
                        string temp = items[i - 1];
                        items[i - 1] = items[i];
                        items[i] = temp;
                        swapped = true;
                    }
                    else
                    {
                        // do nothing
                        swapped = false;
                    }
                } while (swapped == true);
            }
        }

        // Part 4

        static List<string> MergeSort(List<string> merge)
        {
            if (merge.Count <= 1)
            {
                //return merge;
            }
            List<string> L = new List<string>();
            List<string> R = new List<string>();
            int half = merge.Count / 2;
            for (int i = 0; i < merge.Count; i++)
            {
                if (i < half)
                {
                    L.Add(merge[i]);
                }
                else
                {
                    R.Add(merge[i]);
                }
            }
            return Merge(L, R);

            static List<string> Merge(List<string> R, List<string> L)
            {
                List<string> result = new List<string>();
                while (L.Count != 0 && R.Count != 0)
                {
                    if (L[0].CompareTo(R[0]) == -1 || L[0].CompareTo(R[0]) == 0)
                    {
                        result.Add(L[0]);
                        L.RemoveAt(0);
                    }
                    else
                    {
                        result.Add(R[0]);
                        R.RemoveAt(0);
                    }
                }
                while (R.Count != 0)
                {
                    result.Add(R[0]);
                    R.RemoveAt(0);
                }
                return result;
            }
        }



        // Part 5
        // Recursive

        static int BinarySearch(List<string> sortedList, string searchTerm, int low, int high)
        {
            int mid = (low + high) / 2;
            int compare = sortedList[mid].CompareTo(searchTerm);
            if (high < low)
            {
                return -1;
            }
            if (compare == 1)
            {
                return BinarySearch(sortedList, searchTerm, low, mid - 1);
            }
            else if (compare == -1)
            {
                return BinarySearch(sortedList, searchTerm, mid + 1, high);
            }
            else
            {
                return mid;
            }
        }

        //Save

        static void Save(string filePath)
        {
            string name = "What is the name of the save file? ";
            string fileName = ReadString(name, ref choice);
            filePath = Path.ChangeExtension(filePath, ".json");
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                using (JsonTextWriter jsonWriter = new JsonTextWriter(sw))
                {
                    JsonSerializer serial = new JsonSerializer();
                    serial.Serialize(jsonWriter, tList);
                }
            }
        }

    }
}
