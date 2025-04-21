public class Product
{
    public string Name { get; set; }
    public string Category { get; set; }
}

class Program
{
   static void Main(string[] args)
    {
        var products = new List<Product>
        {
            new Product { Name = "Apple", Category = "Fruits" },
            new Product { Name = "Carrot", Category = "Vegetables" },
            new Product { Name = "Banana", Category = "Fruits" },
            new Product { Name = "Broccoli", Category = "Vegetables" }
        };

        var selecteProduct = products.GroupBy(c => c.Category);
        foreach (var category in selecteProduct)
        {
            Console.WriteLine(category.Key);
            foreach (var person in category)
            {
                Console.WriteLine(person.Name);
            }
            Console.WriteLine();
        }
    }
}
