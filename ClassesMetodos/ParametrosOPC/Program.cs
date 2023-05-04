Email email = new();
email.Send(email: "nicholasreis00@gmail.com");

public class Email
{
    public void Send(string email, string title="Default Title", string subject="Default Subject")
    {
        System.Console.WriteLine($"{email}, {title}: {subject}");
    }
}