using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shipping_quote_for_a_package
{
    class Program
    {
        static void Main(string[] args)
        {   //program starting with Welcome
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
            //package weight
            Console.WriteLine("Package Weight");
            int packageWeight = 50;
            bool tooHeavy = (packageWeight > 50);
            Console.WriteLine("Package too heavy to be shipped via Package Express.Have a good day.");
            //program end
            //starting new program 
            int packageWidth = 30;
            int packageHeight = 10;
            int packageLength = 20;
            int total = packageWidth + packageHeight + packageLength;
            if (total > 50) ;
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }

            //program end
            //starting new program 
            int packageWidth = 30;
            int packageHeight = 10;
            int packageLength = 20;
            int packageWeight = 50;
            Console.WriteLine("Please enter package width: ");
            string width = Console.ReadLine();
            Console.WriteLine("Please enter package height: ");
            string height = Console.ReadLine();
            Console.WriteLine("Please enter package length: ");
            string length = Console.ReadLine();
            Console.WriteLine("Please enter package weight: ");
            string weight = Console.ReadLine();
            //multiply the three dimensions and multiply the product by the weight divide the outcome by 100.
            double result = (packageHeight * packageWidth * packageLength) * packageWeight / 100.0;
            Console.WriteLine($"Your estimated total for shipping this package is:${result}");
            Console.WriteLine("Thank you!");
            Console.ReadLine();


        }
    }
}