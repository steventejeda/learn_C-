using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classess___Basics
{
     //this class is a bluprint for a datatyoe
     class Human
    {
        //members variable
        private string firstName;
        private string lastName;
        private string eyeColor;
        private int age;

        //default constructor
        public Human()
        {
            Console.WriteLine("Constructor called. Object created");
        }

        //parameterized Constructor
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;


        }

       //Constructor for firstname and lastname

        public Human(string firstName, string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;

            
        }


        //Constructor only for firstname

        public Human(string firstName)
        {
            this.firstName = firstName;
        }

        //member method
        public void IntroduceMyself()
        {
            if (age != 0 && firstName != null && lastName != null && eyeColor != null) {
                Console.WriteLine($"Hi, I'm {firstName} {lastName}. My eye color is {eyeColor} and I'm {age} years old.");
            } else if (firstName != null && lastName != null && eyeColor != null) 
            {
                Console.WriteLine($"Hi, I'm {firstName} {lastName} and my eye color is {eyeColor}");
            } else if (firstName != null && lastName != null)
            {
                Console.WriteLine($"Hi, my full name is {firstName} {lastName}");
            } else if (firstName != null)

            {
                Console.WriteLine($"Hi, my first name is {firstName}");
            } else
            {
                Console.WriteLine("Invalid info");
            }
            
        }
    }  
}
