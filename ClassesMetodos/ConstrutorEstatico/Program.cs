Person joao = new(name: "joão", sex: "M", age: 18);

joao.ShowData();

public class Person
{
    static int minimumAge;
    static string defaultSex;
    static string defaultName;

    public int age;
    public string name;
    public string sex;

    static Person()
    {
        minimumAge = 18;
        defaultName = "John";
        defaultSex = "M";
    }
    public Person(string name, string sex, int age)
    {
        this.name = name;
        this.sex = sex;
        this.age = age;
    }
    public void ShowData()
    {
        System.Console.WriteLine($"\nName: {name}");
        System.Console.WriteLine($"Sex: {sex}");
        System.Console.WriteLine($"Age: {age}");

        System.Console.WriteLine($"\nDefault Name: {defaultName}");
        System.Console.WriteLine($"Default Sex: {defaultSex}");
        System.Console.WriteLine($"Minimum Age: {minimumAge}");
    }


}