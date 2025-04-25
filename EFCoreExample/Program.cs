using Microsoft.EntityFrameworkCore;
using EFCoreExample;

namespace EFCoreExample
{
    class Program
    {
        static void Main(string[] args)
        {

            // Dein normaler Anwendungs-Code hier
            using (var context = new AppDbContext())
            {
                context.Database.Migrate();
                // Beispielcode für das Hinzufügen von Studenten und Fächern
                var student = new Student { Name = "Onur Arslan", Gender = "Male", Age = 17 };
                var subject = new Subject { Title = "Deutsch" };
                
                student.Subjects.Add(subject);
                context.Students.Add(student);
                context.SaveChanges();

                // Ausgabe der Studenten und der Fächer
                var students = context.Students.ToList();
                foreach (var s in students)
                {
                    Console.WriteLine($"Student: {s.Name}, Age: {s.Age}");
                    foreach (var sub in s.Subjects)
                    {
                        Console.WriteLine($"  - Subject: {sub.Title}");
                    }
                }
            }
        }
    }
}
