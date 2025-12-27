using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignement
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate Employee with type "string" and assign list of strings
            Employee<string> stringEmployee = new Employee<string>("Alice");
            stringEmployee.AddThing("Laptop");
            stringEmployee.AddThing("Notebook");
            stringEmployee.AddThing("Mouse");
            //Instantiate Employee with type "int" and assign list of integers
            Employee<int> intEmployee = new Employee<int>("Bob");
            intEmployee.AddThing(101);
            intEmployee.AddThing(202);
            intEmployee.AddThing(303);
            //Create loops to print all the Things to the Console
            Console.WriteLine($"--- {stringEmployee.Name}'s Things ---");
            foreach (string thing in stringEmployee.Things)
            {
                Console.WriteLine(thing);
            }
            Console.WriteLine($"\n--- {intEmployee.Name}'s Things ---");
            foreach (int thing in intEmployee.Things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
