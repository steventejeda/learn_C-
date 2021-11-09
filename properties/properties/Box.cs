using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
     class Box
    {
        //member varibles
        public int length;
        public int height;
        public int width;
        public int volume;

        public void DisplayInfo()
        {
            volume = length * width * height;
            Console.WriteLine($"length is {length}, height is {height}, and width is {width} so the volume is {volume}");
        }
    }
}
