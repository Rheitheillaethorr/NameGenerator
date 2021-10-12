using System;
using System.IO;

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
                Console.WriteLine("Man");
                ReadNameTextFile("MaleNames.txt");
            }
            else if(gender=="f")
            {
                Console.WriteLine("Women");
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
            //  string line;
            //   StreamReader FileReader = new StreamReader(TextFileName);
            //   for (int i = 0; i==RandomNumber; i++)
            //   {}
            //   Console.WriteLine(line);
        }
    }
}
