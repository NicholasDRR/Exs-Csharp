Registration registration = new();

//Registrando cliente
Client client = registration.Register();
registration.ShowData(client);

// Alterar salário
registration.Register(client);
registration.ShowData(client);

//Mostrando com mensagem de texto
registration.ShowData("Special Client", client);


public class Client
{
    public string? Name;
    public int Age;
    public int Salary;
    public Client(string name, int age, int salary)
    {
        Name = name;
        Age = age;
        Salary = salary;
    }
    public Client()
    {
    }
}
public class Registration
{
    public Client Register()
    {
        Client client = new("João", 18, 1500);
        return client;
    }
    public Client Register(Client client)
    {
        client.Salary = 1800;
        return client;
    }
    public void ShowData(Client client)
    {
        System.Console.WriteLine($"\nName: {client.Name}");
        System.Console.WriteLine($"Age: {client.Age}");
        System.Console.WriteLine($"Salary: {client.Salary.ToString("c")}");
    }
    public void ShowData(string text, Client client)
    {
        System.Console.WriteLine($"\n{text}");
        System.Console.WriteLine($"Name: {client.Name}");
        System.Console.WriteLine($"Age: {client.Age}");
        System.Console.WriteLine($"Salary: {client.Salary.ToString("c")}");
    }
}
