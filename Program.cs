using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.length = 3;
            box1.height = 4;
            box1.width = 5;

            box1.DisplayInfo();
        }
        
    }
}