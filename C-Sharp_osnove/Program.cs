using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;

namespace C_Sharp_osnove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //8
            //int, long, short, float, double, decimal, char, string
            int firstInt = 3;
            int secondInt = 5;
            bool trueOrFalse = true;
            char letterOfTheAlphabet = 'a';
            string someString = "hello";
            //9
            var thirdInt = 8;

            //10
            Console.WriteLine(firstInt + secondInt);
            Console.WriteLine(firstInt - secondInt);
            Console.WriteLine(secondInt / firstInt);
            Console.WriteLine((double)secondInt / firstInt);
            firstInt += 2;
            firstInt *= 3;

            double decimalNumber = 123.45;
            Console.WriteLine(decimalNumber / secondInt);

            //11
            //double enteredNumber = int.Parse(Console.ReadLine());
            double enteredNumber = double.Parse(Console.ReadLine());

            //12
            if(enteredNumber > decimalNumber)
                Console.WriteLine("uneseni je veci");
            else if(firstInt == decimalNumber)
                Console.WriteLine("Isti su!");
            else
                Console.WriteLine("uneseni je manji");

            var enteredInteger = int.Parse(Console.ReadLine());

            switch (enteredInteger)
            {
                case 1:
                    Console.WriteLine("Wow unio si broj jedan!");
                    break;
                case 2:
                    Console.WriteLine("Wow unio si broj dva!");
                    break;
                case 3:
                    Console.WriteLine("Wow unio si broj tri!");
                    break;
                case 4:
                    Console.WriteLine("Wow unio si broj četiri!");
                    break;
                default:
                    break;
            }

            //13
            var numberOfHours = int.Parse(Console.ReadLine());
            var moneyPaidOut = double.Parse(Console.ReadLine());
            var decision = 0;

            var payPerHour = moneyPaidOut / numberOfHours;
            Console.WriteLine(payPerHour);

            if (payPerHour < 50)
                decision = 1;
            else if (payPerHour >= 100)
                decision = 2;

            //14
            var enumDecision = Decision.Considering;

            var payPerHourAgain = moneyPaidOut / numberOfHours;
            Console.WriteLine(payPerHour);

            if (payPerHourAgain < 50)
                enumDecision = Decision.Refused;
            else if (payPerHourAgain >= 100)
                enumDecision = Decision.Accepted;

            Console.WriteLine(enumDecision);

            //15
            var myList = new List<int>() { 4, 8, 12 };

            myList.Add(16);
            myList.Remove(8);
            Console.WriteLine(myList.IndexOf(4));

            //16
            var i = 0;
            while (i < myList.Count)
            {
                Console.WriteLine(myList[i]);
                i++;
            }

            for (var j = 0; j < myList.Count; j++)
            {
                myList[j] += 4;
                Console.WriteLine(myList[j]);
            }

            var elementCounter = 0;
            foreach (var item in myList)
            {
                elementCounter++;
                Console.WriteLine(item);
            }
            Console.WriteLine(elementCounter);

            //17
            var myString = "    string";
            myString += " je imutabilan     ";
            Console.WriteLine(myString);
            Console.WriteLine($"{myString} interpoliramo ovako");
            Console.WriteLine("ovo je kompozitno formatiranje: {0}", myString );

            Console.WriteLine(myString.Trim().ToUpper());

            //18
            var verse = "stani lave stani";
            Console.WriteLine(ReverseString(verse));

            //20
            var myTuple = new Tuple<string, string>("srebrni", "Opel");

            Console.WriteLine(myTuple.Item1);

            var myNewTuple = ( "hello", true );
            Console.WriteLine(myNewTuple.Item1);

            var myNamedTuple = (Color: "srebrni", Brand: "Opel");
            Console.WriteLine(myNamedTuple.Color);

            //21
            var myDictionary = new Dictionary<int, string>()
            {
                {1312, "hej" },
                {232,  "bok"}
            };
            Console.WriteLine(myDictionary[1312]);

            var myOtherDictionary = new Dictionary<string, string>()
            {
                {"Mate", "Miso" },
                {"Mislav",  "Bago"}
            };
            myOtherDictionary["neki"] = "lik";
            myOtherDictionary["jos neki"] = "drugi lik";

            Console.WriteLine(myOtherDictionary["Mislav"]);

            foreach (var pair in myOtherDictionary)
            {
                Console.WriteLine(pair.Key);
                Console.WriteLine(pair.Value);
            }

            //22
            var officeObjects = new Dictionary<string, int>()
            {
                {"Printer", 10 },
                {"Ormar", 35},
                {"Projektor", 5 }
            };

            var officeObject = FindLightestObject(officeObjects);
            Console.WriteLine(officeObject.Item1 + ' ' + officeObject.Item2);

            var lightestObject = FindLightestObjectNamed(officeObjects);
            Console.WriteLine(lightestObject.name + ' ' + lightestObject.weight);

            (var name, var weight) = FindLightestObjectNamed(officeObjects);
            Console.WriteLine(name + ' ' + weight);

            (var destructuredName, var destructuredWeight) = FindLightestObject(officeObjects);
            Console.WriteLine(destructuredName + ' ' + destructuredWeight);
        }

        //14
        enum Decision
        {
            Considering,
            Accepted,
            Refused
        }

        //16
        static string ReverseString(string stringToReverse)
        {
            var reversedString = "";

            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                reversedString += stringToReverse[i];
            }

            return reversedString;
        }
        static string ReverseStringProperly(string stringToReverse)
        {
            var reversedString = new StringBuilder("");

            for (int i = stringToReverse.Length - 1; i >= 0; i--)
            {
                reversedString.Append(stringToReverse[i]);
            }

            return reversedString.ToString();
        }

        //19
        static Tuple<string, int> FindLightestObject(Dictionary<string, int> objectsInOffice)
        {
            var lightestObject = new Tuple<string, int>("None", 0);

            foreach (var officeObject in objectsInOffice)
            {
                if (officeObject.Value < lightestObject.Item2 || lightestObject.Item2 == 0)
                {
                    lightestObject = new Tuple<string, int>(officeObject.Key, officeObject.Value);
                }
            }

            return lightestObject;
        }

        static (string name, int weight) FindLightestObjectNamed(Dictionary<string, int> objectsInOffice)
        {
            var lightestObject = ("None", 0);

            foreach (var officeObject in objectsInOffice)
            {
                if(officeObject.Value < lightestObject.Item2 || lightestObject.Item2 == 0)
                {
                    lightestObject = (officeObject.Key, officeObject.Value);
                }
            }

            return lightestObject;
        }
    }
}
