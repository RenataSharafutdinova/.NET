public enum MembershipType {Monthly,Yearly,Dropl}

interface IPerson
{
    void DisplayInfo();
    string GetRole();

}
public struct ContactInfo
{
    public string Email {  get; set; }
    public string PhoneNumber {  get; set; }

    public override string ToString()
    {
        return $"Email: {Email}, PhoneNumber: {PhoneNumber}";
    }
}

public abstract class Person:IPerson { 
    public string FirstName {  get; set; }
    public string LastName { get; set; }
    public ContactInfo Contact { get; set; }

    public virtual void DisplayInfo()
    {
        Console.WriteLine($"FirstName: {FirstName}, LastName: {LastName}");
        Console.WriteLine($"Contact: {Contact}");
    }
    public abstract string GetRole();
}

public class Client : Person
{
    public string ClientId { get; set; }
    public MembershipType Membership;

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Client ID: {ClientId}");
        Console.WriteLine($"Membership: {Membership}");
        Console.WriteLine();
    }
    public override string GetRole()
    {
        return "Client";
    }
}

public class Trainer : Person 
{ 
    public string TrainerId { get; set; }
    public List<string> Specializations { get; set; }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Trainer ID: {TrainerId}");
        Console.WriteLine($"Specialization:");
       foreach( var special in Specializations ) Console.WriteLine(special.ToString());
    }
    public override string GetRole()
    {
        return "Client";
    }
}
public class FitnessCenter
{
    public List<Client> Clients = new List<Client>();

    public List<Trainer> Trainers = new List<Trainer>();

    public void AddClient( Client client)
    {
        Clients.Add( client );
        Console.WriteLine($"Client {client.FirstName} {client.LastName} added");
    }
    public void AddTrainer( Trainer trainer)
    {
        Trainers.Add( trainer );
        Console.WriteLine($"Trainer {trainer.FirstName} {trainer.LastName} added");
    }
    public void DisplayAllClients()
    {
        Console.WriteLine("!!!!!!All clients:!!!!!!");
        foreach (var client in Clients)
        {
            client.DisplayInfo();
        }
    }

    public void DisplayAllTrainers()
    {
        Console.WriteLine("!!!!!!All trainers!!!!!!:");
        foreach(var trainer in Trainers)
        {
            trainer.DisplayInfo();
        }
    }

}

class Program
{
    static void Main(string[] args)
    {
        var fitnessCenter = new FitnessCenter();
        var client1 = new Client
        {
            FirstName = "John",
            LastName = "Doe",
            Contact = new ContactInfo { Email = "john@example.com", PhoneNumber = "123456789" },
            ClientId = "CL001",
            Membership = MembershipType.Monthly
        };

        var client2 = new Client
        {
            FirstName = "Jane",
            LastName = "Smith",
            Contact = new ContactInfo { Email = "jane@example.com", PhoneNumber = "987654321" },
            ClientId = "CL002",
            Membership = MembershipType.Yearly
        };

        var trainer1 = new Trainer
        {
            FirstName = "Mike",
            LastName = "Johnson",
            Contact = new ContactInfo { Email = "mike@example.com", PhoneNumber = "555123456" },
            TrainerId = "TR001",
            Specializations = new List<string> { "Yoga", "Pilates" }
        };

        var trainer2 = new Trainer
        {
            FirstName = "Sarah",
            LastName = "Williams",
            Contact = new ContactInfo { Email = "sarah@example.com", PhoneNumber = "555654321" },
            TrainerId = "TR002",
            Specializations = new List<string> { "WeightLifting", "CrossFit" }
        };


        fitnessCenter.AddClient(client1);
        fitnessCenter.AddClient(client2);
        fitnessCenter.AddTrainer(trainer1);
        fitnessCenter.AddTrainer(trainer2);

        fitnessCenter.DisplayAllClients();
        fitnessCenter.DisplayAllTrainers();
    }
}
