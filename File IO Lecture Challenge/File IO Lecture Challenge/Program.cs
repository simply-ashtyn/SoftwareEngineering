using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO_Lecture_Challenge
{
    enum Superpower
    {
        Flight, Teleportation, Telekinesis, XRayVision, Strength, Speed, Money, Invisibility, Water
    }
    class Superhero
    {
        public string Name { get; set; }
        public string Secret { get; set; }
        public Superpower Power {get; set;}
    }
    class Program
    {
        static void Main(string[] args)
        {
            string filePath = "Challenge.txt";
            WriteData(filePath);
            ReadData(filePath);

            filePath = Path.ChangeExtension(filePath, ".json");

            List<Superhero> hero = new List<Superhero>();
            hero.Add(new Superhero() { Name = "Batman", Secret = "Bruce Wayne", Power = Superpower.Money });
            hero.Add(new Superhero() { Name = "Wonder Woman", Secret = "Diana Prince", Power = Superpower.Strength });
            hero.Add(new Superhero() { Name = "Flash", Secret = "Barry Allen", Power = Superpower.Speed });
            hero.Add(new Superhero() { Name = "Iron Man", Secret = "Tony Stark", Power = Superpower.Flight });

            using (JsonTextWriter jtw = new JsonTextWriter(sw))
            {
                jtw.Formatting = Formatting.Indented;
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(jtw, hero);
            }

            

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {

                }
            }


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

        static void ReadData(string fPath)
        {
            using (StreamReader sr = new StreamReader(fPath))
            {
                Console.WriteLine("---------DATA---------");
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] data = line.Split(',');
                    List<int> DATA = new List<int>();
                    foreach (string item in data)
                    {
                        if (int.TryParse(item, out int number))
                        {
                            DATA.Add(number);
                        }
                    }
                    foreach (int item in DATA)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
        }
    }
}
