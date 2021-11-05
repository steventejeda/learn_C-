using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_basics
{
    class Human
    {
        public string firstName;
        public void IntroduceMyself()
        {
            Console.WriteLine($"Hello, my name is {firstName}");
        }
    }
}
