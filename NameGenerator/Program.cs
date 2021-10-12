using System;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, choose your gender!");
            Console.WriteLine("Write m or f");
            Console.WriteLine("m - male");
            Console.WriteLine("f - female");
            string gender = Console.ReadLine();
            if (gender=="m")
            {
                Console.WriteLine("Man");
            }
            else if(gender=="f")
            {
                Console.WriteLine("Women");
            }
            else
            {
                Console.WriteLine("You choosed wrong letter");
            }
        }
    }
}
