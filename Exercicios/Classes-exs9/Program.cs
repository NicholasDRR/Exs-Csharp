Client client = new("João", "joão@gmail.com", 10);

Client.ShowData(name: client.Name, email: client.Email);

Client.ShowData(name: client.Name, email: client.Email, client.Age);


public struct Client
{
    public string Name;
    public string Email;
    private int age;
    public int Age 
    {
        get { return age; }
        set
        {
            if (value < 18)
                age = 18;
            else
                age = value;
        }
    }

    public Client(string name, string email, int age)
    {
        Name = name;
        Email = email;
        Age = age;
    }

    public static void ShowData(string name, string email, int age = 10)
    {
        System.Console.WriteLine($"\nClient name: {name}");
        System.Console.WriteLine($"Client email: {email}");
        System.Console.WriteLine($"Client age: {age}\n");
    }




}