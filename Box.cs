using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Box
    {
        //member variables
        private int length = 3;
        public int height;
        public int width;
        public int volume;

        public void SetLength(int length)
        {
            this.length = length;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Legnth is {0}, height is {1}, adn width is {2}. so the volume is {3}", length, height, width, volume = length*height*width);
        }

    }
}
