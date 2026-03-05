using System;
using System.Collections.Generic;
using System.Text;

namespace Project_5_1_
{
    internal class LessonStudents
    {
        private HashSet<Student> students = new HashSet<Student>();

        public void RegisterStudent(Student student)
        {
            if (students.Contains(student))
            {
                Console.WriteLine($"Student with ID {student.Id} is already registered.");
            }
            else
            {
                students.Add(student);
                Console.WriteLine($"Student with ID {student.Id} registered successfully.");
            }
        }
        public IEnumerable<Student> GetRegisteredStudents()
        {
            return students;
        }
        public void PrintRegisteredStudents()
        {
            Console.WriteLine("Registered Students:");
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Full Name: {student.FullName}");
            }
        }
    }
}
