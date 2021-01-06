using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(5, 7));
        }

        public static int Multiply(int num1, int num2)
        {
            return num1 * num2;
        }

    }
}