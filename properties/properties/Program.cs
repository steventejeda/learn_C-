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
            Box box = new Box();
            box.length = 1;
            box.width = 2; 
            box.height = 3;

            box.DisplayInfo();
            Console.Read();
        }
    }
}

    
    
    
  