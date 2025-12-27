using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    class Employee:IQuittable
    {
        // create another class, "Employee" and have it inherit from the Person class
        
            public string Name { get; set; }
            public Employee(string name)
            {
                Name = name;
            }
            public void Quit()
            {
                Console.WriteLine($"{"Name"} has quit the job.");
                Console.ReadLine();

            }
        }
    }

