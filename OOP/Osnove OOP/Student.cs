using System;
using System.Collections.Generic;
using System.Text;

namespace Osnove_OOP
{
    public class Student : Person
    {
        public Student(string firstName, string lastName, string attendedCollege) : base(firstName, lastName)
        {
            AttendedCollege = attendedCollege;
        }

        public string AttendedCollege { get; set; }

        public override void Work()
        {
            Console.WriteLine("I dont work im a student");
        }

        public override void StopWork()
        {
            base.StopWork();
        }
    }
}
