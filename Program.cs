using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("Enter a string and press enter :");
            string readInput = Console.ReadLine();
            Console.WriteLine("You have entered {0}", readInput);

            Console.Write("Enter a string and press enter :");
            int asciiValue = Console.Read();
            Console.WriteLine("ASCII value is {0}:", asciiValue);
            Console.ReadKey();
            
        }
    }
}