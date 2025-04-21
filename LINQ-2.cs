public class Book
{
    public string Title { get; set; }
}
class Program
{
   static void Main(string[] args)
    {
        var books = new List<Book>
        {
            new Book { Title = "1984" },
            new Book { Title = "To Kill a Mockingbird" },
            new Book { Title = "The Great Gatsby" },
            new Book { Title = "Война и мир" },  
            new Book { Title = "Анна Каренина" }
        };


        var selectedBooks = from b in books
                              orderby b.Title
                              select b;
        foreach (var book in selectedBooks)
        {
            Console.WriteLine($"Title: {book.Title}");
        }
    }
}
