using System;
using System.Collections.Generic;
using System.Text;

namespace Project_5_1_
{
    internal class BaseProfiles
    {
        private Dictionary<int, Student> Students = new Dictionary<int, Student>();

        public void AddStudent(Student student)
        {
            Students[student.Id] = student;
        }
        public Student? GetStudent(int id)
        {
            if (Students.TryGetValue(id, out var student))
            {
                return student;
            }
            return null;
        }

        public IEnumerable<Student> GetAllStudents()
        {
          return Students.Values;
        }
    }
}
