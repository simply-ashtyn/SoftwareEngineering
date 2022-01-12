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

            //ListChallenge();


            //DICTIONARIES
            //Random grade = new Random();
            //Dictionary<string, double> students = new Dictionary<string, double>()
            //{
            //    {"Steve", grade.NextDouble() * 100 },
            //    {"April", grade.NextDouble() * 100 },
            //    {"Lisa", grade.NextDouble()* 100 },
            //    {"Tom", grade.NextDouble()* 100 },
            //    {"Susan", grade.NextDouble()* 100 },
            //    {"Luke", grade.NextDouble()* 100}
            //};
            //students.Add("William", grade.NextDouble() * 100);
            //students.Add("Sarah", grade.NextDouble() * 100);
            //students["Kyle"] = grade.NextDouble() * 100;
            //students["Charlie"] = grade.NextDouble() * 100;
            //PrintGrades(students);
            //DropStudent(students);
            //PrintGrades(students);
            

            string text = "I say to you today, my friends, so even though we face the difficulties of today and tomorrow, I still have a dream. It is a dream deeply rooted in the American dream. " +
                "I have a dream that one day this nation will rise up and live out the true meaning of its creed: We hold these truths to be self-evident: that all men are created equal. " +
                "I have a dream that one day on the red hills of Georgia the sons of former slaves and the sons of former slave owners will be able to sit down together at the table of brotherhood. " +
                "I have a dream that one day even the state of Mississippi, a state sweltering with the heat of injustice, sweltering with the heat of oppression, will be transformed into an oasis of freedom and justice. " +
                "I have a dream that my four little children will one day live in a nation where they will not be judged by the color of their skin but by the content of their character. " +
                "I have a dream today. I have a dream that one day, down in Alabama, with its vicious racists, with its governor having his lips dripping with the words of interposition and nullification; one day right there in Alabama, little black boys and black girls will be able to join hands with little white boys and white girls as sisters and brothers. " +
                "I have a dream today. I have a dream that one day every valley shall be exalted, every hill and mountain shall be made low, the rough places will be made plain, and the crooked places will be made straight, and the glory of the Lord shall be revealed, and all flesh shall see it together. " +
                "This is our hope. This is the faith that I go back to the South with. With this faith we will be able to hew out of the mountain of despair a stone of hope. With this faith we will be able to transform the jangling discords of our nation into a beautiful symphony of brotherhood. " +
                "With this faith we will be able to work together, to pray together, to struggle together, to go to jail together, to stand up for freedom together, knowing that we will be free one day. " +
                "This will be the day when all of God's children will be able to sing with a new meaning, My country, 'tis of thee, sweet land of liberty, of thee I sing. Land where my fathers died, land of the pilgrim's pride, from every mountainside, let freedom ring. " +
                "And if America is to be a great nation this must become true. So let freedom ring from the prodigious hilltops of New Hampshire. Let freedom ring from the mighty mountains of New York. Let freedom ring from the heightening Alleghenies of Pennsylvania! " +
                "Let freedom ring from the snowcapped Rockies of Colorado! Let freedom ring from the curvaceous slopes of California! But not only that; let freedom ring from Stone Mountain of Georgia! " +
                "Let freedom ring from Lookout Mountain of Tennessee! Let freedom ring from every hill and molehill of Mississippi. From every mountainside, let freedom ring. " +
                "And when this happens, when we allow freedom to ring, when we let it ring from every village and every hamlet, from every state and every city, we will be able to speed up that day when all of God's children, black men and white men, Jews and Gentiles, Protestants and Catholics, will be able to join hands and sing in the words of the old Negro spiritual, Free at last! free at last! thank God Almighty, we are free at last!";

            char[] delim = new char[] { ' ', ',', '.', '"', '+' };
            string[] words = text.Split(delim, StringSplitOptions.RemoveEmptyEntries);
            List<string> word = words.ToList();

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
            //Histogram(wordCount);
            foreach (var item in wordCount)
            {
                Console.WriteLine(item);
            }
            

            Console.ReadKey();
        }


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

