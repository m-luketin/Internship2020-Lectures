using System;
using System.Collections.Generic;
using System.Text;

namespace Osnove_OOP
{
    public class Person
    {
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }

        private bool _isWorking = false;

        virtual public void Work()
        {
            if(!_isWorking)
            {
                Console.WriteLine("Werkin'");
                _isWorking = true;
            }
            else
            {
                Console.WriteLine("Already werkin'");
            }
        }

        virtual public void StopWork()
        {
            if (_isWorking)
            {
                Console.WriteLine("Stopped werkin'");
                _isWorking = false;
            }
            else
            {
                Console.WriteLine("Already chillin'");
            }
        }
    }
}
