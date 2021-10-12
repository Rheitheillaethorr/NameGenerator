using System;
using System.IO;
using System.Linq;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, choose your gender!");
            AskForGender();
        }

        static void AskForGender()
        {
            Console.WriteLine("Write m or f");
            Console.WriteLine("m - male");
            Console.WriteLine("f - female");
            string gender = Console.ReadLine();
            if (gender=="m")
            {
                ReadNameTextFile("MaleNames.txt");
            }
            else if(gender=="f")
            {
                ReadNameTextFile("FemaleNames.txt");
            }
            else
            {
              Console.WriteLine("You choosed wrong letter, try again");
                AskForGender();
            }
        }
        static void ReadNameTextFile(string TextFileName)
        {
            int lineCount = File.ReadAllLines(TextFileName).Length;
            Random rnd = new Random();
            int RandomNumber = rnd.Next(0, lineCount);
            string line = File.ReadLines(TextFileName).Skip(RandomNumber-1).Take(1).First();
            Console.WriteLine("Generated name is: " + line);
        }
    }
}
