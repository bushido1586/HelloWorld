﻿using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 13;
            int num2 = 20;
            int sum = num1 + num2;

            double d1 = 3.5;
            double d2 = 4.337;
            double sumD = d1 / d2;
            

            Console.WriteLine("The sum of " + num1 + " and " + num2+" is " +sum);
            Console.WriteLine(d1 + " divided by "+ d2+ " is " +sumD);
            Console.Read();
        }
    }
}