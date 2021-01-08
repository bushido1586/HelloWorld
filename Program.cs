using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            string numberAsString = "128";
            int parsedValue;
            bool success = int.TryParse(numberAsString, out parsedValue);
            if (success)
            {
                Console.WriteLine("Parsing successful - number is "+ parsedValue);
            }
            else { Console.WriteLine("parsing failed"); }
        }
        
    }
}