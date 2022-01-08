using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LectureProgramPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //string gmsg = GetMessage();
                //PrintMessage(gmsg);
                //TimeStamp(ref gmsg);
                //Console.WriteLine(gmsg);

                MyFavoriteNumber();


                Console.WriteLine("\n\n\nPress any key to exit");
                Console.ReadKey();
            }

        }

        public static void MyFavoriteNumber(out int favorite)
        {
            Console.WriteLine("What is your favorite number?");
            int fav = int.Parse(Console.ReadLine());

        }

        public static void TimeStamp(ref string message)
        {
            message = $"{DateTime.Now} {message}";
        }

        public static void PrintMessage(string messagetoprint)
        {
            Console.WriteLine(messagetoprint);
        }
        public static string GetMessage()
        {
            Console.Write("Enter a message:  ");
            string message = Console.ReadLine();
            return message;
        }
    }
    }
}
