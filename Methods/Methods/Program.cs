using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = "steven";
            string name2 = "stephany";
            string name3 = "noah";
            GreetFriend(name1, name2, name3);
        }

        public static void GreetFriend(string name1, string name2, string name3)
        {
            Console.WriteLine($"Hi {name1}, my friend!");
            Console.WriteLine($"Hi {name2}, my friend!");
            Console.WriteLine($"Hi {name3}, my friend!");
            Console.Read();
        }

    }
}