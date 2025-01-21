using System;
using System.Collections.Generic;
using System.Linq;
namespace lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int>() { 2, 4, 6, 7, 1, 4, 2, 9, 1 };
            var q1 = Numbers.Distinct().OrderBy(x => x);
            foreach (var num in q1)
            {
                Console.WriteLine(num);
            }

            var q2 = q1.Select(n => new { Number = n, Multiplication = n * n });
            foreach (var item in q2)
            {
                Console.WriteLine($"Number: {item.Number}, Multiplication: {item.Multiplication}");

            }

            string[] names = { "Tom", "dick", "Harry", "Marry", "Jay" };

            var q3 = names.Where(name => name.Length == 3);
            foreach (var name in q3)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("\n");

            var q4 = names.Where(n => n.Contains("a"));
            foreach (var name in q4)
            {
                Console.WriteLine(name);
            }

            var q5 = names.Take(2);
            Console.WriteLine("\n");
            foreach (var name in q5)
            {
                Console.WriteLine(name);
            }



            List<Student> students = new List<Student>
            {
                new Student
                {
                    ID = 1,
                    FirstName = "Ali",
                    LastName = "Mohammed",
                    Subjects = new Subject[]
                    {
                        new Subject { Code = 22, Name = "EF" },
                        new Subject { Code = 33, Name = "UML" }
                    }
                },
                new Student
                {
                    ID = 2,
                    FirstName = "Mona",
                    LastName = "Gala",
                    Subjects = new Subject[]
                    {
                        new Subject { Code = 22, Name = "EF" },
                        new Subject { Code = 34, Name = "XML" },
                        new Subject { Code = 25, Name = "JS" }
                    }
                },
                new Student
                {
                    ID = 3,
                    FirstName = "Yara",
                    LastName = "Yousf",
                    Subjects = new Subject[]
                    {
                        new Subject { Code = 22, Name = "EF" },
                        new Subject { Code = 25, Name = "JS" }
                    }
                },
                new Student
                {
                    ID = 1,
                    FirstName = "Ali",
                    LastName = "Ali",
                    Subjects = new Subject[]
                    {
                        new Subject { Code = 33, Name = "UML" }
                    }
                }
            };

            var query1 = students.Select(s => new
            {
                FullName = $"{s.FirstName} {s.LastName}",
                SubjectCount = s.Subjects.Length
            });

            Console.WriteLine("\n");
            foreach (var student in query1)
            {
                Console.WriteLine($"Name: {student.FullName}, Subjects: {student.SubjectCount}");
            }

            var query2 = students.OrderByDescending(s => s.FirstName)
                                 .ThenBy(s => s.LastName)
                                 .Select(s => new { s.FirstName, s.LastName });

            Console.WriteLine("\n");
            foreach (var student in query2)
            {
                Console.WriteLine($"FirstName: {student.FirstName}, LastName: {student.LastName}");
            }
        
    







        }
    }
}
