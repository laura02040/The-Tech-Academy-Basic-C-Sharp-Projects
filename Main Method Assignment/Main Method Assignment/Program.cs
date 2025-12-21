using System;


namespace Main_Method_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instantiate the MathMethods2 class
            MathMethods2 math1 = new MathMethods2();
            //Call the first method with an int parameter
            Console.WriteLine(math1.MathOp(7));
            //call the second method with a decimal parameter
            Console.WriteLine(math1.MathOp(7.3m));
            //Call the third method with a string parameter
            Console.WriteLine(math1.MathOp("7"));
            Console.ReadLine();
        }
    }
}
