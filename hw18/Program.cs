namespace hw18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Choose number of task(1-7): ");
                int.TryParse(Console.ReadLine(), out int task);
                if (task == 0) break;

                switch (task)
                {
                    case 1:
                        int num = 8;
                        Console.WriteLine(num.FibonacciCheck());
                        break;
                    case 2:
                        string str = "Hello, world!";
                        Console.WriteLine(str.WordsAmount());
                        break;
                    case 3:
                        string str1 = "Hello, world!";
                        Console.WriteLine(str1.LengthOfLastWord());
                        break;
                    case 4:
                        string str2 = "[[{}]]";
                        string str3 = "{}[]";
                        Console.WriteLine(str2.BracketsCheck());
                        Console.WriteLine(str3.BracketsCheck());
                        break;
                    case 5:
                        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                        int[] pairNumbers = numbers.Filter(n => n % 2 == 0);
                        Console.WriteLine("Even Numbers: ");
                        foreach (int number in pairNumbers)
                            Console.Write(number + " ");
                        Console.WriteLine();
                        break;
                    case 6:
                        var temperatures = new DaytimeTemperature[]
                        {
                            new DaytimeTemperature() { Highest = 35.5, Lowest = 20.1 },
                            new DaytimeTemperature() { Highest = 40.1, Lowest = 21.3 },
                            new DaytimeTemperature() { Highest = 26.2, Lowest = 14.8 },
                        };
                        foreach (var temperature in temperatures)
                        {
                            File.AppendAllText("Temperature.txt", temperature.Highest.ToString());
                            File.AppendAllText("Temperature.txt", temperature.Lowest.ToString());
                        }
                        Console.WriteLine($"The day with the maximum temperature difference is day: {temperatures.DayTemperatureDifference()}");
                        break;
                    case 7:
                        var students = new StudentGrades[]
                        {
                            new StudentGrades()
                            {
                                StudentName = "Alice",
                                Grades = new Dictionary<string, double> { { "Math", 85 }, { "Science", 90 }, { "History", 78 } }
                            },
                            new StudentGrades()
                            {
                                StudentName = "Bob",
                                Grades = new Dictionary<string, double> { { "Math", 92 }, { "Science", 88 }, { "History", 80 } }
                            }
                        };
                        foreach (var student in students)
                        {
                            File.AppendAllText("Students.txt", student.StudentName);
                            File.AppendAllText("Students.txt", student.Grades.ToString());
                        }
                        Console.WriteLine($"The student with the maximum average grade is {students.StudentWithMaxAverageGrade()}.");
                        break;
                }
            }
        }
    }
}
