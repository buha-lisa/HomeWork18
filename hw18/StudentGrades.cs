
namespace hw18
{
    public class StudentGrades
    {
        public string StudentName { get; set; }
        public Dictionary<string, double> Grades { get; set; }
    }

    public static class StudentGradesExtensions
    {
        public static string StudentWithMaxAverageGrade(this StudentGrades[] students)
        {
            string topStudent = null;
            double topAverageGrade = double.MinValue;

            foreach (var student in students)
            {
                double averageGrade = 0;
                foreach (var grade in student.Grades.Values)
                {
                    averageGrade += grade;
                }
                averageGrade /= student.Grades.Count;

                if (averageGrade > topAverageGrade)
                {
                    topStudent = student.StudentName;
                    topAverageGrade = averageGrade;
                }
            }

            return topStudent;
        }
    }
}
