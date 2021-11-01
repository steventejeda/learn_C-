using System;

namespace IntroApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Foo("Steven");
            Foo("Tejeda");
        }
        static void Foo(string name)
        {
            Console.WriteLine("In foo...");
            Console.WriteLine(name);
            
        }
    }
}
