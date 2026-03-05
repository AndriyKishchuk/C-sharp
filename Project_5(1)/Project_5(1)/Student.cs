using System;
using System.Collections.Generic;
using System.Text;

namespace Project_5_1_
{
    internal class Student
    {
        public int Id { get; set; }
        public string? FullName { get; }

        private SortedDictionary<DateTime, int> grades = new SortedDictionary<DateTime, int>();

        public Student(int id, string? fullName)
        {
            Id = id;
            FullName = fullName;
        }

        public void AddGrade(DateTime date, int grade)
        {
            grades[date] = grade;
        }

        public void PrintGrades()
        {
            Console.WriteLine($"Grades for {FullName} (ID: {Id}):");
            foreach (var entry in grades)
            {
                Console.WriteLine($"Date: {entry.Key.ToShortDateString()}, Grade: {entry.Value}");
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is null)
            {
                return false;
            }
            return obj is Student student && Id == student.Id;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }
    }
}
