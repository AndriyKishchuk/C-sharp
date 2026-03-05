using Project_5_1_;
using System;
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        var system = new StudentManagmentSystem();


        Console.WriteLine("1. Adding Students ");
        system.AddStudent(101, "Іван");
        system.AddStudent(102, "Марфія");
        system.AddStudent(103, "Вася");

        Console.WriteLine("\n2. All Students in Database\n");
        system.PrintAllStudents();


        Console.WriteLine("\n3. Registered Students for Lesson\n");
        system.PrintRegisteredStudents();


        Console.WriteLine("\n4. Adding Grades ===\n");
        system.AddGradeToStudent(101, new DateTime(2026, 1, 15), 5);
        system.AddGradeToStudent(101, new DateTime(2026, 1, 22), 10);
        system.AddGradeToStudent(101, new DateTime(2026, 2, 5), 11);

        system.AddGradeToStudent(102, new DateTime(2026, 1, 20), 2);
        system.AddGradeToStudent(102, new DateTime(2026, 2, 10), 9);

        system.AddGradeToStudent(103, new DateTime(2026, 1, 10), 10);
        system.AddGradeToStudent(103, new DateTime(2026, 1, 25), 9);
        system.AddGradeToStudent(103, new DateTime(2026, 2, 15), 8);

        Console.WriteLine("\n5. Grade History\n");
        system.PrintStudentGrades(101);
        Console.WriteLine();
        system.PrintStudentGrades(102);
        Console.WriteLine();
        system.PrintStudentGrades(103);

        Console.WriteLine("\n6. Registering Students to Lesson\n");

        system.RegisterStudentToLesson(101);

        system.LostObject();
    }
}