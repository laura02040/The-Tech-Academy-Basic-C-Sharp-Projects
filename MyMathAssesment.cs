using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math2
{
    class MyMathAssesment
    {
        //method that takes two integers as parameters
        public int MathOp(int number, int number2)
        {
            return number + 7;
        }
        public int MathOp(decimal number)
        {
            int newnum = Convert.ToInt32(number);
            return newnum * 20;
        }
        //Call the method in the class, passing in two numbers.
        public int Add(int a, int b)
        {
            return a + b;
        }
        //Call the method in the class, specifying the parameters by name.
        static void DisplayInfo(string name, int age, string city)
        {
            Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
            Console.ReadLine();
        }
    }
}
