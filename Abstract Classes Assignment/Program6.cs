using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // In the Main method, instantiante an Employee object
            Employee sam = new Employee() { firstName = "Sample", lastName = "Student" };
            //Call the sayName method on the object
            sam.SayName();
            Console.ReadLine();
        }
    }
}
