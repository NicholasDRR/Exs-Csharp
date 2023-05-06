Client.name = "Kond";
Client.age = 18;

Client.ShowData();



public class Client
{
    public static string? name;
    public static int age;

    public static void ShowData()
    {
        System.Console.WriteLine($"Name: {name}");
        System.Console.WriteLine($"Age: {age}");
    }

}