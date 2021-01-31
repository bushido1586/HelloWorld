using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            int counter = 0;
            string enteredText = "";
            while(enteredText.Equals(""))
            {
                Console.WriteLine("Please hit enter to increase count by 1. Any other input plus enter to finish");
                enteredText = Console.ReadLine();
                counter++;
                Console.WriteLine("Current people count is {0}", counter);
            }
        }


        
    }
}