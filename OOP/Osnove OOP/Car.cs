using System;
using System.Collections.Generic;
using System.Text;

namespace Osnove_OOP
{
    public class Car
    {
        public Car(string make, string model)
        {
            Make = make;
            Model = model;
            GasInLiters = 20;
        }

        private bool _isStarted = false;

        public string Make { get; set; }
        public string Model { get; set; }
        public float GasInLiters { get; set; }

        public void Start()
        {
            if (!_isStarted)
            {
                _isStarted = true;
                Console.WriteLine("Car started");
            }
            else
                Console.WriteLine("Car already started");
        }

        public void Stop()
        {
            if(!_isStarted)
                Console.WriteLine("Car already stopped");
            else
            {
                _isStarted = false;
                Console.WriteLine("Car stopped");
            }
        }
    }
}
