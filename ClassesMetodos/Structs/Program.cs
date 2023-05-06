Client josias = new("josias", 19);
josias.ShowData();

public struct Client
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Client(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public void ShowData()
    {
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"Age: {Age}");
    }
}
