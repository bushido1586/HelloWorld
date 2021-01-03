using System;

namespace HelloWorld
{  
    class Program
    {

        static void Main(string[] args)
        {
            //implicit conversion
            int num = 55179;
            long bigNumber = num;

            float myFloat = 13.37f;
            double myNewDouble = myFloat;

            double myDouble = 13.37;
            int myInt;
            //Explicit conversion
            //cast double to int;
            myInt = (int)myDouble;

            //type conversion
            string myString = myDouble.ToString();//-"13.37"
            num.ToString();
            string myFloatString = myFloat.ToString();

            bool sunIsShining = false;

            string myBoolString = sunIsShining.ToString();

            Console.WriteLine(myBoolString);

            
            
        }
    }
}