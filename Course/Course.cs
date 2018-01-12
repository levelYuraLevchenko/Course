using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Course
    {
        public string Name { get; set; }
        public Teacher Teacher { get; set; }
        public Student[] Students { get; set; }

        public void SetStudents(Student[] Students)
        {
            if (Students.Length > 5)
                return;
            this.Students = Students;
        }

        public void СonclusionTeacherName()
        {
            Console.WriteLine("Teacher :" + Teacher.TeacherName);
        }

        public void СonclusionStudentsName()
        {
            for (var i = 0; i < Students.Length; i++)
            {
                Console.WriteLine("Student :" + Students[i].StudentName);
            }
        }

        public void StudentProgress()
        {
            for (var i = 0; i < Students.Length; i++)
            {
                Console.WriteLine(Students[i].StudentName + " " + Students[i].StudentMark);
            }
        }
    }
}
