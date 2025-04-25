using System;
using System.Linq;

namespace EFCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new AppDbContext())
            {
                // Adding a new student
                var student = new Student { Name = "John Doe", Age = 20 };
                context.Students.Add(student);
                context.SaveChanges();

                // Querying the student
                var query = context.Students.Where(s => s.Name == "John Doe");

                foreach (var stud in query)
                {
                    Console.WriteLine($"Student: {stud.Name}, Age: {stud.Age}");
                }
            }
        }
    }
}