using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    public class Student
    {
        public string StudentName { get; set; }
        public int StudentMark { get; set; }
        public string CourseName { get; set; }

        public Student(string StudentName, string CourseName)
        {
            this.StudentName = StudentName;
            this.CourseName = CourseName;
        } 
    }
}
