using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.Write("235 ");
            string userInput = Console.ReadLine();

            //Logs that number to a text file.
            Console.WriteLine(userInput);
            File.WriteAllText("path", txt);

            //Prints the text file back to the user.
            Console.WriteLine(userInput);
            using (StreamWriter file=new StreamWriter("path",true))
            {
                file.WriteLine(userInput);
            }
        }
    }
}
