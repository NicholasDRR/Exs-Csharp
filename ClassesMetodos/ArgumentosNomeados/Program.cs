Email email = new();
email.Send(destiny: "nicholasreis00@gmail.com", 
subject: "You've been selected", title: "Job Alert");

public class Email
{
    public void Send(string destiny, string title, string subject)
    {
        System.Console.WriteLine($"{destiny}, {title}: {subject}");
    }
}