using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Basics
{
    //this class is a blueprint for a datatype
    class Program
    {
        //member variable
        public string firstname;
        static void Main(string[] args) 
        {
            //create an object of my class
            //an instance of Human
            Human steven = new Human(); 
            steven.firstname = "Steven";
            steven.IntroduceMyself();
             



        }
}