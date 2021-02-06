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
                nums[i] = i+10;
            }

            for(int j =0; j<nums.Length; j++)
            {
                Console.WriteLine("elements{0} = {1}", j, nums[j]);
            }
            int counter = 0;

            foreach(int k in nums)
            {
                Console.WriteLine("elements{0} = {1}",counter++,k);
            }
            
        }
        
    }
}