using System;
using System.Collections.Generic;
using System.Linq;

public class Article
{
    public string Title { get; set; }
    public string Author { get; set; }
    public string Journal { get; set; }
    public int Year { get; set; }

    public override string ToString()
    {
        return $"{Title} by {Author} ({Journal}, {Year})";
    }

    public override bool Equals(object obj)
    {
        if (obj is Article other)
        {
            return Title == other.Title && Year == other.Year;
        }
        return false;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Title, Year);
    }

    public static bool operator ==(Article a, Article b)
    {
        if (ReferenceEquals(a, null))
            return ReferenceEquals(b, null);
        
        return a.Equals(b);
    }

    public static bool operator !=(Article a, Article b)
    {
        return !(a == b);
    }
}

public class ArticleCollection
{
    private List<Article> articles = new List<Article>();

    public Article this[int index]
    {
        get => articles[index];
        set => articles[index] = value;
    }

    public void AddArticle(Article article)
    {
        if (article == null)
            throw new ArgumentNullException(nameof(article));
        
        articles.Add(article);
    }

    public bool RemoveArticle(string title, int year)
    {
        var articleToRemove = articles.FirstOrDefault(a => 
            a.Title == title && a.Year == year);
        
        if (articleToRemove != null)
        {
            return articles.Remove(articleToRemove);
        }
        return false;
    }

    public List<Article> FindArticlesByAuthor(string author)
    {
        return articles
            .Where(a => a.Author.Equals(author, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public List<Article> FindArticlesByJournal(string journal)
    {
        return articles
            .Where(a => a.Journal.Equals(journal, StringComparison.OrdinalIgnoreCase))
            .ToList();
    }

    public List<Article> FindArticlesByYear(int year)
    {
        return articles.Where(a => a.Year == year).ToList();
    }

    public List<Article> GetAllArticles()
    {
        return new List<Article>(articles);
    }
}

class Program
{
    static void Main(string[] args)
    {
        var collection = new ArticleCollection();
        
        collection.AddArticle(new Article 
        { 
            Title = "Machine Learning Advances", 
            Author = "John Smith", 
            Journal = "AI Research", 
            Year = 2021 
        });
        
        collection.AddArticle(new Article 
        { 
            Title = "Quantum Computing", 
            Author = "Alice Johnson", 
            Journal = "Physics Today", 
            Year = 2022 
        });
        
        collection.AddArticle(new Article 
        { 
            Title = "Neural Networks", 
            Author = "John Smith", 
            Journal = "AI Research", 
            Year = 2020 
        });

        Console.WriteLine("Статьи John Smith:");
        foreach (var article in collection.FindArticlesByAuthor("John Smith"))
        {
            Console.WriteLine(article);
        }

        bool removed = collection.RemoveArticle("Neural Networks", 2020);
        Console.WriteLine($"\nСтатья 'Neural Networks' удалена: {removed}");

        Console.WriteLine("\nВсе статьи в коллекции:");
        foreach (var article in collection.GetAllArticles())
        {
            Console.WriteLine(article);
        }
    }
}
