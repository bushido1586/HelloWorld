using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            string[] friends = { "Paul", "Kristin", "Holly", "Matt", "Aaron" };

            foreach(string name in friends)
            {
                Console.WriteLine("Hello, {0}!", name);
            }
            
        }
        
    }
}