using System;

namespace HelloWorld
{

    class Program
    {

        static void Main(string[] args)
        {
            Box box1 = new Box();
            box1.SetLength(4);
            box1.height = 4;
            box1.width = 5;

            //Console.WriteLine("box1 length is " + box1.length);

            box1.DisplayInfo();
        }
        
    }
}