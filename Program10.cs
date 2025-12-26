using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            e1.Id = 1;
            e1.FirstName = "Bob";
            e1.LastName = "Jones";
             Employee e2 = new Employee();
            e2.Id = 2;
            e2.FirstName = "Luke";
            e2.LastName = "Jon";
            if (e1 == e2)
            {
                Console.WriteLine("e1 is equal to e2");
            }
            else
            {
                Console.WriteLine("e1 is not equal e2");
            }
                Console.ReadLine();
            }
    }
}
