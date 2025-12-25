using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism_Assignment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Use polymorphism to create an object of type IQuittable and call the Quit() method on it
            IQuittable quitter = new Employee { Name = "Alice" };
            quitter . Quit();
            Console.ReadLine();
        }
    }
}
