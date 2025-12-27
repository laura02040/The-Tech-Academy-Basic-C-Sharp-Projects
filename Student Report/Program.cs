using System;

namespace StudentReport
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Academy of Learning Career College");
            Console.WriteLine("Student Daily Report");
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();
            Console.WriteLine("What course are you on?");
            String course = Console.ReadLine();
            Console.WriteLine("What page number?");
            int pageNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Do you need Help with anything? Please answer \"true\"or\"false");
            String needHelp = Console.ReadLine();
            bool needHelpBool =bool.Parse(needHelp);
            Console.WriteLine("Where there any positive expence you'd like to share? Please give specifics");
            string positiveExpences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific");
            string feedback = Console.ReadLine();
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            int studyHoursNum = Convert.ToInt32(studyHours);
            Console.WriteLine("Thank you for your answer. An instuctor will respond to ths shortly. Have a great day!");
            Console.ReadLine();
        }
    }
}

