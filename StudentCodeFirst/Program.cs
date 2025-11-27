using System;

namespace StudentCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new StudentContext())
            {
                var student = new Student
                {
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2000, 1, 1)
                };

                context.Students.Add(student);
                context.SaveChanges();
            }

            Console.WriteLine("Student added successfully!");
            Console.ReadKey();
        }
    }
}
