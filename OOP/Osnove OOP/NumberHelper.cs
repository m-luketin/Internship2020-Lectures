using System;
using System.Collections.Generic;
using System.Text;

namespace Osnove_OOP
{
    public static class NumberHelper
    {
        public static int Add(int firstNumber, int secondNumber)
        {
            var addedValue = firstNumber + secondNumber;
            Console.WriteLine(addedValue);

            return addedValue;
        }
    }
}
