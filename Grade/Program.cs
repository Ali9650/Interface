namespace Grade
{
    internal class Program
    {
        static void Main()
        {
            Grade grade = new Grade("History", Degree.A);
            Student student = new Student();
            student.AddGrade(grade);
            student.GetAllGrades();
        }
    }
}


