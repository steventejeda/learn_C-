using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace properties
{
    class Program
    {
        static void Main(string[] args)
        {
            Box box = new Box(3, 4, 5);

            Console.WriteLine($"Box's width is {box.Width}");
            Console.WriteLine($"Box's height is {box.Height}");
            Console.WriteLine($"Box's length is {box.Length}");



            //box.DisplayInfo();
            Console.Read();
        }
    }

}




  