Email email = new();
email.Send("Paulista");
email.Send("Paulista", "Commercial rent");
email.Send("Paulista", 10000);


public class Email {

    public void Send(string? address)
    {
        System.Console.WriteLine($"\n{address}");
        System.Console.WriteLine($"Standart subject");
    }
    public void Send(string? address, string? subject)
    {
        System.Console.WriteLine($"\n{address}");
        System.Console.WriteLine($"{subject}");
    }
    public void Send(string? address, int value)
    {
        System.Console.WriteLine($"\n{address}");
        System.Console.WriteLine($"Commercial Proposal");
        System.Console.WriteLine($"{value}");
    }
}