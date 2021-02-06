using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            int[] grades = new int[5];

            grades[0] = 20;
            grades[1] = 15;
            grades[2] = 16;
            grades[3] = 10;
            grades[4] = 5;


            Console.WriteLine("grades at index 0 : {0}", grades[0]);

            string input = Console.ReadLine();
            //assign value to array at 0 index
            grades[0] = int.Parse(input);

            Console.WriteLine("grades at index 0 : {0}", grades[0]);
            //other intilization options
            int[] mathGradesClassA = { 20, 13, 12, 8, 8 };

            int[] mathGradesClassB = new int[] { 15, 20, 3, 17, 18, 15 };

            Console.WriteLine("Length of grades for Class A: {0}", mathGradesClassA.Length);
            
        }
        
    }
}