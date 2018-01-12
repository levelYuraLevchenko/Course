using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Program 
    {
        static void Main(string[] args)
        {
            var net = new Course();
            net.Name = "C#/.Net";

            var unity = new Course();
            unity.Name = "Unity3D";

            net.Teacher = new Teacher("Tim", net.Name);

            unity.Teacher = new Teacher("Oleg",unity.Name);

            var studentsNet = new Student[]
            {
                new Student("Andrey",net.Name),
                new Student("Dima", net.Name),
                new Student("Nikita", net.Name),
                new Student("Yura", net.Name),
                new Student("Oleg", net.Name)
            };

            var studentsUnity = new Student[]
            {
                new Student("Alex", unity.Name),
                new Student("Vlad", unity.Name),
                new Student("Misha", unity.Name),
                new Student("Jony", unity.Name),
                new Student("Max", unity.Name)
            };

            net.SetStudents(studentsNet);
            unity.SetStudents(studentsUnity);

            net.Teacher.SetRating(studentsNet[0], 3);
            net.Teacher.SetRating(studentsNet[1], 3);
            net.Teacher.SetRating(studentsNet[2], 4);
            net.Teacher.SetRating(studentsNet[3], 4);
            net.Teacher.SetRating(studentsNet[4], 5);

            unity.Teacher.SetRating(studentsUnity[0], 5);
            unity.Teacher.SetRating(studentsUnity[1], 5);
            unity.Teacher.SetRating(studentsUnity[2], 4);
            unity.Teacher.SetRating(studentsUnity[3], 4);
            unity.Teacher.SetRating(studentsUnity[4], 3);

            Console.WriteLine(net.Name);
            Console.WriteLine();
            net.СonclusionTeacherName();
            net.СonclusionStudentsName();
            Console.WriteLine();
            net.StudentProgress();

            Console.WriteLine("______________________");
            Console.WriteLine();

            Console.WriteLine(unity.Name);
            Console.WriteLine();
            unity.СonclusionTeacherName();
            unity.СonclusionStudentsName();
            Console.WriteLine();
            unity.StudentProgress();
        }
    }

}
