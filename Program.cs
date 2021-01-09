using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("What is the temperature today?");
            string temperature = Console.ReadLine();
            int numTemp;
            int number;
            if (int.TryParse(temperature, out number))
            {
                numTemp = number;
            }
            else
            {
                numTemp = 0;
                Console.WriteLine("Value entered in incorect fomrat, temp set as 0");
            }
            if (numTemp < 20)
            {
                Console.WriteLine("Take a coat");
            }else if ( numTemp == 20)
            {
                Console.WriteLine("Pants and pullover should be ok");
            }else if (numTemp >= 30)
            {
                Console.WriteLine("Its hot today, shorts are good");
            }
      
        }
        
    }
}