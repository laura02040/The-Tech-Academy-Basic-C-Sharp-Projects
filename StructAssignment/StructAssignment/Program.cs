using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructAssignment
{ 
    public class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Create an object of type Number
                Number myNumber = new Number();

                // Assign an amount to it
                myNumber.Amount = 123.45m; // 'm' suffix for decimal literals

                // Print the amount to the console
                Console.WriteLine($"The amount is: {myNumber.Amount}");
            }
            catch (Exception ex)
            {
                // Handle unexpected errors gracefully
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
