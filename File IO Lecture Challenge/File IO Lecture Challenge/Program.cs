using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Lecture_Challenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Challenge.txt";
            WriteData(filePath);
            ReadData();


            Console.ReadKey();
        }

        static void WriteData(string filePath)
        {
            List<int> numbers = new List<int>();
             
            char delim = ',';
            Random num = new Random();
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(num.Next(0, 500));
            }
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                for (int i = 0; i < numbers.Count; i++)
                {
                    sw.Write(numbers[i]);
                    sw.Write(delim);
                }
            }
        }

        static void ReadData()
        {
            string filePath = @"C:\Users\ashty\OneDrive\Documents\Visual Studio 2019\Projects\GitHub\File IO Lecture Challenge\File IO Lecture Challenge\bin\Debug\Challenge.txt";
            using (StreamReader sr = new StreamReader(filePath))
            {
                Console.WriteLine("---------DATA---------");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    List<string> DATA = data.ToList();
                    foreach (var item in DATA)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
