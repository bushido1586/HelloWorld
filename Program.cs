using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Please enter today's temp in degrees C");
            string temp = Console.ReadLine();
            int tempNum = int.Parse(temp);
            if(tempNum < 20)
            {
                Console.WriteLine("Put on a coat");
            }
            if (tempNum == 20)
            {
                Console.WriteLine("Pants and pullover fine");
            }

            if (tempNum > 20)
            {
                Console.WriteLine("Shorts are enough today");
            }
        }
        
    }
}