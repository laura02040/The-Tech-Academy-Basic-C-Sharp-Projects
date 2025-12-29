using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Ask the user for their age.
                Console.Write("Please enter your age: ");
                string input = Console.ReadLine();
                int age = int.Parse(input);
                //Display appropriate error messages if the user enters zero or negative numbers.
                if (age <= 0)
                {
                    Console.WriteLine("Error: Age must be a positive number greater than zero.");
                    Console.ReadLine();
                    return;
                }

                int currentYear = DateTime.Now.Year;
                int birthYear = currentYear - age;

                Console.WriteLine($"You were born in {birthYear}.");
                Console.ReadLine();
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Please enter a valid whole number for age.");
                Console.ReadLine();
            }
            catch (Exception)
            {//Display a general message if an exception was caused by anything else.
                Console.WriteLine("An unexpected error occurred. Please try again.");
                Console.ReadLine();
            }
        }
    }
}
    

