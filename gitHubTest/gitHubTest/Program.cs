using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gitHubTest
{
    class Program
    {
        //Lecture challenges:

        static void Main(string[] args)
        {
            //ArrayChallenge();

            ListChallenge();
            

            //DICTIONARIES
            Random grade = new Random();
            Dictionary<string, double> students = new Dictionary<string, double>()
            {
                {"Steve", grade.NextDouble() * 100 },
                {"April", grade.NextDouble() * 100 },
                {"Lisa", grade.NextDouble()* 100 },
                {"Tom", grade.NextDouble()* 100 },
                {"Susan", grade.NextDouble()* 100 },
                {"Luke", grade.NextDouble()* 100}
            };
            students.Add("William", grade.NextDouble() * 100);
            students.Add("Sarah", grade.NextDouble() * 100);
            students["Kyle"] = grade.NextDouble() * 100;
            students["Charlie"] = grade.NextDouble() * 100;
            PrintGrades(students);
            DropStudent(students);
            PrintGrades(students);

            Console.ReadKey();
        }
        static void DropStudent(Dictionary<string, double> students)
        {
            Console.Write("Enter the students name you wish to remove from the list: ");
            string name = Console.ReadLine();
            bool wasDropped = students.Remove(name);
            if (wasDropped)
            {
                Console.WriteLine($"{name} was dropped from the course.");
            }
            else
            {
                Console.WriteLine($"{name} was not found amoung pg2 students.");
            }
        }

        static void PrintGrades(Dictionary<string, double> sGrades)
        {
            foreach (KeyValuePair<string, double> item in sGrades)
            {
                Console.WriteLine($"{item.Key,-15} {item.Value,7:N2}");
            }
        }

        private static void ArrayChallenge()
        {
            int[] nums = new int[10];
            Random num = new Random();
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = num.Next(0, 500);
            }
            foreach (int number in nums)
            {
                Console.WriteLine(number);
            }

            //1
            List<int> numList = nums.ToList();
            //2
            List<int> numList2 = new List<int>(nums);
            //3
            List<int> numList3 = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                numList3.Add(nums[i]);
            }
        }

        static void ListChallenge()
        {
            List<double> grades = new List<double>(10);
            Random grade = new Random();
            for (int i = 0; i < 10; i++)
            {
                grades.Add(grade.Next(0, 100));
            }
            foreach (var grd in grades)
                Console.ForegroundColor = (grd < 59.5) ? ConsoleColor.Red :
                                (grd < 69.5) ? ConsoleColor.DarkYellow :
                                (grd < 79.5) ? ConsoleColor.Yellow :
                                (grd < 89.5) ? ConsoleColor.Blue :
                                                     ConsoleColor.Green;
            PrintGrades(grades);
            int removed = DropFailing(grades);
            Console.WriteLine(removed + " grades removed");
            PrintGrades(grades);
            List<double> newGrades = CurveGrades(grades);
            PrintGrades(newGrades);
        }
        
        static void PrintGrades(List<double> grade)
        {
            Console.WriteLine("----------------GRADES----------------");
            for (int i = 0; i < grade.Count; i++)
            {
                Console.WriteLine(grade[i]);
            }
            Console.ResetColor();
        }

        static int DropFailing(List<double> grade)
        {
            int removed = 0;
            for (int i = 0; i < grade.Count; i++)
            {
                if (grade[i] < 59.5)
                {
                    removed++;
                    grade.RemoveAt(i);
                    i--;
                }
            }

            //or use reverse for loop

            //for (int i = grade.Count; i >= 0; i--)
            //{
            //    if (grade[i] < 59.5)
            //    {
            //        removed++;
            //        grade.RemoveAt(i);
            //        i--;
            //    }
            //}
            return removed;
        }

        static List<double> CurveGrades(List<double> grades)
        {
            List<double> curvedGrade = new List<double> (grades);
            for (int i = 0; i < curvedGrade.Count; i++)
            {
                curvedGrade[i] += 5;

                if (curvedGrade[i] > 100)
                {
                    curvedGrade[i] = 100;
                }
            }
            return curvedGrade;

        }


    }
}

