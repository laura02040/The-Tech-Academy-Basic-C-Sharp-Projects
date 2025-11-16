using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //this is do while loop
            int count = 0;
            do
            {
                Console.WriteLine("Inside the loop");
                count++; //add one to count each time
            }
            while (count < 5); //continue to loop until count reaches 5
            //this is while loop
            int counting = 0;
            while (counting < 3) //continue to loo[p until counting reach 3
            {
                Console.WriteLine("Counting numbers");
                counting++; //add one to countingf each time
            }
            Console.ReadLine();
        }
    }
}
