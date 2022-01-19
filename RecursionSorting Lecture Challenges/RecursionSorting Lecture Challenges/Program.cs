using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecursionSorting_Lecture_Challenges
{
    class Program
    {
        //qjH*%#4J

        static void Main(string[] args)
        {
            //int i = 0;
            //Bats(i);

            //Console.Write("Enter a number: ");
            //int input = int.Parse(Console.ReadLine());
            //long result = Factorial(input);
            //Console.WriteLine($"{input} factorial = {result}");

            //int[] numbers = new int[] {8,5,1,2,9,3,6,4 };
            //PrintArray(numbers);
            //Swap(numbers, 0,1);
            //Console.WriteLine("\nPress any key to sort");
            //Console.ReadKey();
            //PrintArray(numbers);

            //Console.Write("Enter your favorite superhero: ");
            //string super = Console.ReadLine();
            //Console.Write("Now enter your favorite Villain: ");
            //string vill = Console.ReadLine();
            //Console.WriteLine("\nWho will win?");
            //Console.WriteLine("\n------------FIGHT!-----------");
            //Console.ReadKey();
            //CompareString(super,vill);

            List<int> numbs = new List<int>() { 7, 6, 5, 9, 1, 4, 3, 8 };
            //Split(numbs);

            int foundIndex = LinearSearch(numbs, 6);
            Console.WriteLine($"6 is at index: {foundIndex}");


            Console.ReadKey();

        }

        private static int LinearSearch(List<int> N, int find)
        {
            int index = -1;
            for (int i = 0; i < N.Count; i++)
            {
                if (N[i] == find)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }

        private static void CompareString(string a, string b)
        {
            int result = a.CompareTo(b);
            if (result == -1)
            {
                Console.WriteLine($"{b} has defeated {a}!");
            }
            else if (result == 0)
            {
                Console.WriteLine("It's a draw!");
            }
            else
            {
                Console.WriteLine($"{a} has defeated {b}!");
            }
        }

        private static void PrintArray(int[] numbers)
        {
            foreach (var item in numbers)
            {
                Console.Write($"{item}, ");
            }
        }

        static void Bats(int i)
        {
            if (i < 100)
            {
                Console.Write((char)78);
                Console.Write((char)65);
                Console.Write(' ');
                Bats(i + 1);
            }
        }

        static long Factorial(int f)
        {
            long result = 1;
            if (f > 1)
            {
                result = f * Factorial(f - 1);
            }
            return result;

        }

        static void Swap(int[] num, int index1, int index2)n
        {
            int temp = num[index1];
            num[index1] = num[index2];
            num[index2] = temp;
        }

        static void Split(List<int> nums)
        {
            List<int> L = new List<int>();
            List<int> R = new List<int>();
            int mid = nums.Count / 2;
            for (int i = 0; i < nums.Count; i++)
            {
                if (i < mid)
                {
                    L.Add(nums[i]);
                }
                else
                {
                    R.Add(nums[i]);
                }
            }
            Console.WriteLine("----------Left----------");
            foreach (var item in L)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("----------Right----------");
            foreach (var item in R)
            {
                Console.WriteLine(item);
            }
        }
    }
}
