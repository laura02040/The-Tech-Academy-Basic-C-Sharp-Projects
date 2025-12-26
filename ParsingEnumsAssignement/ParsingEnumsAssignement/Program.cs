using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnumsAssignement
{
    class Program
    {
        //create an enum for the days of the week
        public enum DaysOfTheWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,sunday
        }
        static void Main(string[] args)
        {
            bool isvalid = false;
            while(!isvalid)
            {
                try
                {
                    //Prompt the user to enter the current day of the week
                    Console.WriteLine("Enter the current day of the week");
                    string dayinput = Console.ReadLine();
                    //Assign the value to a variable of that enum data type you just created.
                    DaysOfTheWeek day = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), dayinput);
                    Console.WriteLine("Have are nice" + day);
                    Console.ReadLine();
                    isvalid = true;
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Please enter an actual day of the week");
                }
            }
        }
    }
}
