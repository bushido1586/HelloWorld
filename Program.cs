using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for(int i = 0; i <10; i++)
            {
                nums[i] = i;
            }

            for(int j =0; j<10; j++)
            {
                Console.WriteLine("elements{0} = {1}", j, nums[j]);
            }

            
        }
        
    }
}