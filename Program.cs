﻿using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine(Add(Add(1, 2), Add(3, 4)));
            Console.WriteLine(Add(15,31));
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

    }
}