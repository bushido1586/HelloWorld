using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            int temp = 100;
            string stateOFMater;
            /*
            if (temp < 0)
            
                stateOFMater = "solid";
            
            else
            
                stateOFMater = "liquid";
            */


            //short form
            //Challenge: add gas state

            temp += 100;
            stateOFMater = temp > 100 ? "gas" : temp < 0 ? "solid" : "liquid";
            Console.WriteLine("State of mater is {0}", stateOFMater);

        }


        
    }
}