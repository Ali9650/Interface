

using System.Diagnostics;
using System.Xml.Linq;

namespace Grade
{
    internal class Student
    {
        private Grade[] grades;
        public Grade[] Grades { get => grades; }
        public Student ()
        {
            grades = new Grade[0];
        }
        public void AddGrade(Grade grade)
        {
            Array.Resize(ref grades, grades.Length + 1);
            grades[grades.Length - 1] = grade;
        }



        public void GetAllGrades ()
        {
           foreach (var grade in grades)
            {
                Console.WriteLine($"{grade.Subject} {grade.Degree}");
            }
        }
    }
}
