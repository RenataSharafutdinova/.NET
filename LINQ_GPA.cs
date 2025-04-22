public class Student {
    public string Name {  get; set; }
    public int Age { get; set; }
    public double GPA {  get; set; }
}
class Program
{
   static void Main (string[] args)
    {
        var students = new List<Student>
        {
            new Student { Name = "Alice", Age = 31, GPA = 5.0 },
            new Student { Name = "Bob", Age = 21, GPA = 3.0},
            new Student { Name = "Charlie",Age = 28, GPA = 4.5 },
            new Student { Name = "David",Age = 18, GPA = 4.0 }
        };

        var selectedStudents = students.Where(s => s.Age > 20 && s.GPA > 3.5);
        foreach (var student in selectedStudents)
        {
            Console.WriteLine($"Name: {student.Name}, Age: {student.Age}, GPA: {student.GPA}");
        }
    }
}


