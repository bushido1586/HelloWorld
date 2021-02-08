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

            Console.WriteLine("central value is {0}", array2D[1,1]);

            
        }
        
    }
}