MyClass person = new();

person.SayHello();



class MyClass
{
    public void SayHello()
    {
        System.Console.WriteLine("Welcome!");
        ShowDate();
    }
    public void ShowDate() =>
        System.Console.WriteLine("27-04-2023!");

}

