using System;
using System.Collections.Generic;
using System.Text;

namespace Project_5_1_
{
    internal class StudentManagmentSystem
    {
        private BaseProfiles baseProfiles;
        private LessonStudents lessonStudents;

        public StudentManagmentSystem()
        {
            baseProfiles = new BaseProfiles();
            lessonStudents = new LessonStudents();
        }

        public void AddStudent(int id, string fullName)
        {
            Student student = new Student(id, fullName);
            baseProfiles.AddStudent(student);
            lessonStudents.RegisterStudent(student);
        }

        public void AddGradeToStudent(int studentId, DateTime date, int grade)
        {
            var student = baseProfiles.GetStudent(studentId);
            if (student != null)
            {
                student.AddGrade(date, grade);
                Console.WriteLine($"Grade {grade} added to student {student.FullName} on {date.ToShortDateString()}.");
            }
            else
            {
                Console.WriteLine($"Student with ID {studentId} not found.");
            }
        }
        public void PrintStudentGrades(int studentId)
        {
            var student = baseProfiles.GetStudent(studentId);
            if (student != null)
            {
                student.PrintGrades();
            }
            else
            {
                Console.WriteLine($"Student with ID {studentId} not found.");
            }
        }
        public void PrintRegisteredStudents()
        {
            lessonStudents.PrintRegisteredStudents();
        }
        public void RegisterStudentToLesson(int studentId)
        {
            var student = baseProfiles.GetStudent(studentId);
            if (student != null)
            {
                lessonStudents.RegisterStudent(student);
            }
            else
            {
                Console.WriteLine($"Student with ID {studentId} not found.");
            }
        }
        public void PrintAllStudents()
        {
            Console.WriteLine("All Students:");
            var students = baseProfiles.GetAllStudents();
            foreach (var student in students)
            {
                Console.WriteLine($"ID: {student.Id}, Full Name: {student.FullName}");
            }
        }
        public void LostObject()
        {
            Student testStudent = new Student(889, "John Doe");
            lessonStudents.RegisterStudent(testStudent);
            Console.WriteLine($"Added student to HashSet with ID {testStudent.Id}");

            bool isRegistered = lessonStudents.GetRegisteredStudents().Contains(testStudent);
            Console.WriteLine($"Is the student registered? {isRegistered}");

            testStudent.Id = 89;
            Console.WriteLine($"Changed student ID to {testStudent.Id}");
            bool isStillRegistered = lessonStudents.GetRegisteredStudents().Contains(testStudent);
            Console.WriteLine($"Is the student still registered after ID change? {isStillRegistered}");
        }
    }
}
