
namespace baitapvenha
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    namespace StudentManagement
    {
        class Student
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public int Age { get; set; }
        }

        class Program
        {
            static void Main(string[] args)
            {
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                // Tạo danh sách học sinh
                List<Student> students = new List<Student>
            {
                new Student { Id = 01, Name = "An", Age = 20 },
                new Student { Id = 02, Name = "Duong", Age = 17 },
                new Student { Id = 03, Name = "Bao", Age = 21 },
                new Student { Id = 04, Name = "Thien", Age = 22 },
                new Student { Id = 05, Name = "Tuan", Age = 18 }
            };

                // a. 
                Console.WriteLine("Danh sách toàn bộ học sinh:");
                students.ForEach(s => Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}"));

                // b. 
                Console.WriteLine("\nHọc sinh có tuổi từ 15 đến 18:");
                var filteredStudents = students.Where(s => s.Age >= 15 && s.Age <= 18);
                foreach (var student in filteredStudents)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }

                // c. 
                Console.WriteLine("\nHọc sinh có tên bắt đầu bằng chữ 'A':");
                var studentsWithA = students.Where(s => s.Name.StartsWith("A"));
                foreach (var student in studentsWithA)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }

                // d. 
                int totalAge = students.Sum(s => s.Age);
                Console.WriteLine($"\nTổng tuổi của tất cả học sinh: {totalAge}");

                // e. 
                int maxAge = students.Max(s => s.Age);
                var oldestStudents = students.Where(s => s.Age == maxAge);
                Console.WriteLine("\nHọc sinh có tuổi lớn nhất:");
                foreach (var student in oldestStudents)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }

                // f. 
                Console.WriteLine("\nDanh sách học sinh sắp xếp theo tuổi tăng dần:");
                var sortedStudents = students.OrderBy(s => s.Age);
                foreach (var student in sortedStudents)
                {
                    Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");
                }
            }
        }
    }
}
