using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            //declare 2D array
            string[,] matrix;
            //declare 3D array

            int[,,] threeD;


            //2D array
            int[,] array2D = new int[,]
            {
                {1,2,3},//row 0
                {4,5,6},//row 1
                {7,8,9},//row 2
            };

            Console.WriteLine("central value is {0}", array2D[2,0]);


            //3D array in acation

            string[,,] array3D = new string[,,]
            {
                {
                    {"hello","hi" },
                    {"yo","sup" },
                    {"hi There","What's up" }
                },
                {
                    {"000","001"},
                    {"010", "100" },
                    {"Another one", "Last Entry" }
                }
            };

            Console.WriteLine("The value is {0}", array3D[0,2,0]);

        }
        
    }
}