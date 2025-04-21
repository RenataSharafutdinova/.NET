public class Order
{
    public decimal Amount { get; set; }
}

class Program
{
   static void Main(string[] args)
    {
        var orders = new List<Order>
        {
         new Order { Amount = 150.00m },
         new Order { Amount = 200.00m },
         new Order { Amount = 75.00m }
        };


        var sum = orders.Sum(order=>order.Amount);
        Console.WriteLine(sum);
    }
}
