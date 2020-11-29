using System;
using System.Collections.Generic;

namespace Osnove_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //var myCar = new Car("Opel", "Astra");
            //var mazda = new Car("Mazda", "Miata");

            //Console.WriteLine(myCar.Make);
            //Console.WriteLine(mazda.Make);
            //myCar.Start();
            //myCar.Stop();
            //myCar.Stop();

            //var somePerson = new Person("Some", "Dude");
            //var someStudent = new Student("Ivan", "Ivanovic");
            //var someOtherStudent = new Student("Ivan", "Ivanovic", "FESB");
            //someStudent.Work();
            //someStudent.Work();

            //var someStudent = new Student("Ivan", "Ivanovic", "FESB");
            //someStudent.Work();

            //var a = 2;
            //var b = 3;
            //NumberHelper.Add(a, b);

            //TextHelper.PrintFormattedText("Hello world!");

            //var someNumber = 1;

            //IncrementNumber(ref someNumber);
            //Console.WriteLine(someNumber);

            var referenceType = new Student("Marko", "Kovac", "");
            var valueType = 5;

            ChangeTypes(referenceType, valueType);

            Console.WriteLine(referenceType.AttendedCollege);
            Console.WriteLine(valueType);
        }

        public static void ChangeTypes(Student studentToChange, int intToChange)
        {
            studentToChange.AttendedCollege = "FESB";
            intToChange = 1;
        }
    }
}
