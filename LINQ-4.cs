public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
}
public class Grade
{
    public int StudentId { get; set; }
    public string Subject { get; set; }
    public char LetterGrade { get; set; }
}

class Program
{
   static void Main(string[] args)
    {
        var students = new List<Student>
        {
         new Student { Id = 1, Name = "Alice" },
         new Student { Id = 2, Name = "Bob" }
        };
        var grades = new List<Grade>
        {
         new Grade { StudentId = 1, Subject = "Math", LetterGrade = 'A' },
         new Grade { StudentId = 2, Subject = "Math", LetterGrade = 'B' },
         new Grade { StudentId = 1, Subject = "Science", LetterGrade = 'A' }
        };


        var per = students.Join(grades,
            s=>s.Id,
            g=>g.StudentId,
            (s, g) => new {Name=s.Name,Subject=g.Subject, LetterGrade=g.LetterGrade});

        foreach (var emp in per)
        {
            Console.WriteLine($"{emp.Name},{emp.Subject},{emp.LetterGrade}");
           
        }
    }
}
