using System;
using System.Collections.Generic;

namespace Console_App_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Array of strings
            string[] colorArray = { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black", "White", "Pink", "Brown" };
            // Ask user for number to display the string at that index
            Console.WriteLine("Select a number between 0 and 9:");
            int stringSelect = Convert.ToInt32(Console.ReadLine());
            bool validString = false;
            while (!validString)
            {
                try
                {
                    Console.WriteLine("Your favorite color is " + colorArray[stringSelect]);
                    validString = true;
                }
                //Add a message to display if the user picks an index that doesn't exist
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Please select a number between 0 and 9.");
                    stringSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
            //List of strings
            List<string> occupationList = new List<string>()
            {
                "Data Analyst",
                "UX Designer",
                "Artist",
                "Teacher",
                "Lawyer",
                "Cowboy",
                "Athlete",
                "Podcast Host",
                "Software developer",
                "QA Tester"
        };
            //Ask the user for a number to display the string at that index
            Console.WriteLine("\nSelect another number between 0 and 9:");
            int listSelect = Convert.ToInt32(Console.ReadLine());
            bool validList = false;
            while (!validList)
            {
                try
                {
                    Console.WriteLine("Your new occupation is: " + occupationList[listSelect]);
                    validList = true;
                }
                //Add a message to display if the user picks an index that doesn't exist
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Select a number between 0 and 9.");
                }
            }
            //Array of intergers
            int[] intArray = { 17, 22, 3, 67, 5, 91, 11, 42, 23, 6 };
            //Ask the user for a number to display the string at that index
            Console.WriteLine("\nSelect a third number between 0 and 9:");
            int intSelect = Convert.ToInt32(Console.ReadLine());
            bool validInt = false;
            while (!validInt)
            {
                try
                {
                    Console.WriteLine("Your lucky number is " + intArray[intSelect]);
                    validInt = true;
                }
                //Add a message to display if the user picks a index that doesn't exist
                catch
                {
                    Console.WriteLine("Sorry, that number selection is invalid. Select a number betyween 0 and 9. ");
                    intSelect = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}
    