using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            int num3;


            //unary operator
            num3 = -num1;

            Console.WriteLine("num3 is {0}", num3);

            bool isSunny = true;
            Console.WriteLine("Is it sunny? {0}", !isSunny);

            //increment operators
            int num = 0;
            num++;
            Console.WriteLine("num is {0}", num);
            Console.WriteLine("num is {0}", num++);
            Console.WriteLine("num is {0}", ++num);//pre-increment

            //decriment operator
            Console.WriteLine(num--);
            Console.WriteLine(--num);

            int result;
            result = num1 + num2;
            Console.WriteLine("result of num1 + num2 is {0}",result);
            result = num1 - num2;
            Console.WriteLine("result of num1 - num2 is {0}", result);
            result = num1 / num2;
            Console.WriteLine("result of num1 / num2 is {0}", result);
            result = num1 * num2;
            Console.WriteLine("result of num1 * num2 is {0}", result);

            result = num1 % num2;
            Console.WriteLine("result of num1 % num2 is {0}", result);

            //relational and type operators
            bool isLower;
            isLower = num1 < num2;
            Console.WriteLine("Result of num1 < num2 is {0}", isLower);
            //equality operator
            bool isEqual;
            isEqual = num1 == num2;
            Console.WriteLine("result of num1 == num2 is {0}", isEqual);

            isEqual = num1 != num2;
            Console.WriteLine("result of num1 != num2 is {0}", isEqual);


            // conditional operators
            bool isLowerAndSunny = isLower && isSunny;//and
            Console.WriteLine("reuslt of isLower && isSunny is {0}", isLowerAndSunny);

            isLowerAndSunny = isLower || isSunny;//or
            Console.WriteLine("reuslt of isLower || isSunny is {0}", isLowerAndSunny);

        }
        
    }
}