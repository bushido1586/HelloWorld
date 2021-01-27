using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            for(int i=1; i < 20; i++)
            {
               if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("for loop is done");

        }


        
    }
}