using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace C_Sharp_osnove
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //7
            int firstInt = 3;
            int secondInt = 5;

            //8
            Console.WriteLine(firstInt + secondInt);
            Console.WriteLine(firstInt - secondInt);
            Console.WriteLine(secondInt / firstInt);
            Console.WriteLine((double)secondInt / firstInt);
            firstInt += 2;
            firstInt *= 3;

            double decimalNumber = 123.45;
            Console.WriteLine(decimalNumber / secondInt);

            //9
            //double enteredNumber = int.Parse(Console.ReadLine());
            double enteredNumber = double.Parse(Console.ReadLine());

            //10
            if(enteredNumber > decimalNumber)
                Console.WriteLine("uneseni je veci");
            else if(firstInt == decimalNumber)
                Console.WriteLine("Isti su!");
            else
                Console.WriteLine("uneseni je manji");

            //11
            var numberOfHours = int.Parse(Console.ReadLine());
            var moneyPaidOut = double.Parse(Console.ReadLine());

            var payPerHour = moneyPaidOut / numberOfHours;
            Console.WriteLine(payPerHour);

            if(payPerHour >= 50)
                Console.WriteLine("Moze");
            else
                Console.WriteLine("Ne moze");

            //12
            //var variable;

            //13
            var myList = new List<int>() { 4, 8, 12 };

            myList.Add(16);
            myList.Remove(8);
            Console.WriteLine(myList.IndexOf(4));

            //14
            foreach (var item in myList)
            {
                //item += 4;
                Console.WriteLine(item);
            }

            for (int i = 0; i < myList.Count; i++)
            {
                myList[i] += 4;
                Console.WriteLine(myList[i]);
            }

            for (int i = 0; i < myList.Count; i++)
            {
                myList[i] += 4;
                Console.WriteLine(myList[i]);
            }

            //15
            var myString = "    string";
            myString += " je imutabilan     ";
            Console.WriteLine(myString);
            Console.WriteLine($"{myString} interpoliramo ovako");

            Console.WriteLine(myString.Trim().ToUpper());

            //16
            var verse = "stani lave stani";
            Console.WriteLine(ReverseString(verse));

            //17
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

            //18
            var myTuple = new Tuple<string, string>("srebrni", "Opel");

            var carBrand = myTuple.Item2;

            //19
            var officeObjects = new Dictionary<string, int>()
            {
                {"Printer", 10 },
                {"Ormar", 35},
                {"Projektor", 5 }
            };

            var lightestObject = FindLightestObject(officeObjects);

            Console.WriteLine(lightestObject);
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

        //19
        static Tuple<string, int> FindLightestObject(Dictionary<string, int> objectsInOffice)
        {
            var lightestObject = new Tuple<string, int>("None", 0);

            foreach (var officeObject in objectsInOffice)
            {
                if(officeObject.Value < lightestObject.Item2 || lightestObject.Item2 == 0)
                {
                    lightestObject = new Tuple<string, int>(officeObject.Key, officeObject.Value);
                }
            }

            return lightestObject;
        }

    }
}
