using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Math_Assesment
{
    class Program
    {
        static void Main(string[] args)
        {
                // instantiate the class.
                Calculation math = new Calculation();
                //Call the method in the class, passing in two numbers. 
                Console.WriteLine("Enter first number:");
                if (!int.TryParse(Console.ReadLine(), out int num1))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    return;
                }
                Console.Write("Enter second number: ");
                if (!int.TryParse(Console.ReadLine(), out int num2))
                {
                    Console.WriteLine("Invalid input. Please enter an integer.");
                    return;
                }
                Console.WriteLine("Input is correct!");
                Console.ReadLine();
        }
    }
}
