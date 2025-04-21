public class Student
{
    public string Name { get; set; }
    public int Score { get; set; }
}

class Program
{
   static void Main(string[] args)
    {
        var students = new List<Student>
        {
            new Student { Name = "Alice", Score = 90 },
            new Student { Name = "Bob", Score = 80 },
            new Student { Name = "Charlie", Score = 88 },
            new Student { Name = "David", Score = 92 }
        };

        var selectedStudent = from s in students
                              where s.Score > 85
                              select s;
        foreach (var student in selectedStudent)
        {
            Console.WriteLine($"Name: {student.Name}, Score: {student.Score}");
        }
    }
}
