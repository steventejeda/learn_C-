using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MembersC
{
    class Members
    {
        //member private field 
        private string memberName;
        private string jobTitle;
        private int salary;

        // member - public field 
        public int age;

        //member propertty = exposes jobTitle safely - properties start with a captial letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }
        // public member method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            } else
            {
                Console.WriteLine($"Hi, my name is {memberName}, and my job title is {jobTitle}. I'm {age} years old.");
            }

        }
        private void SharingPrivateInfo()
        {
            Console.WriteLine($"My salary is {salary}");
        }
        //member constructor
        public Members()
        {
            age = 30;
            memberName = "Lucy";
            salary = 60000;
            jobTitle = "Developer";
            Console.WriteLine("Object created");
        }

        //member - finalizer - destructor
        ~Members()
        {
            //clean up statements
            Console.WriteLine("Deconstruction of members object");
        }
    }
}
