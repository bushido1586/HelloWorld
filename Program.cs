using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 0;
            int result;
            try
            {
                result = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Can't divide by zero!");
            }
        }
        
    }
}