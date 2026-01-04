using Students;
using System;

class Program
{
    public static void Main(string[] args)
    {
        using (var context = new StudentContext())
        {
            var student = new Student()
            {
                StudentName = "John Doe"
            };

            context.Students.Add(student);
            context.SaveChanges();

            Console.WriteLine("Student added successfully.");
        }

        Console.ReadLine();
    }
}
