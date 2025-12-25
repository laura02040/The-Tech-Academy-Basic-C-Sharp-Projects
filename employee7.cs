using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
   public class Employee
    {
        // create another class, "Employee" and have it inherit from the Person class
        class employee : IQuittable
        {
            public string Name { get; set; }
            public employee(string name)
            {
                Name = name;
            }
            public void Quit()
            {
                Console.WriteLine($"{"Alise"} has quit the job.");
                Console.ReadLine();
            }
        }
    }
}

