using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Teacher
    {
        public string TeacherName { get; set; }
        public string CourseName { get; set; }

        public Teacher(string TeacherName, string CourseName)
        {
            this.TeacherName = TeacherName;
            this.CourseName = CourseName;
        }

        public void SetRating(Student Students, int StudentMark)
        {
            if (Students.CourseName == CourseName)
            Students.StudentMark = StudentMark;
            else Console.WriteLine("Нельзя поставить оценку студенту другого курса");
        }
    }
}
