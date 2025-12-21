using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Main_Method_Assignment
{
    public class MathMethods2
    {
        //First method that takes an integer
        public int MathOp(int number)
        {
            return number + 7;
        }
        //Second method that takes a decimal
        public int MathOp(decimal number)
        {
            //Convert the decimal to an intn to perform amth operation
            int newnum = Convert.ToInt32(number);
            return newnum * 20;
        }
        //Third MathOp method that takes a string
        public int MathOp(string number)
        {
            //Convert the string to an int to perform math opertion
            int newnum = Convert.ToInt32(number);
            return newnum % 3;
        }
    }
}
