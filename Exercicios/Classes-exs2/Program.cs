Car ford = new("SUV", "Ford");
System.Console.WriteLine($"Model: {ford.Model}");
System.Console.WriteLine($"Assembler: {ford.Assembler}");

var fordSpeed = ford.MaximumSpeed(60);
System.Console.WriteLine($"Max Speed: {fordSpeed}");

public class Car 
{
    public string Model;
    public string Assembler;
    public Car(string model, string assembler)
    {
        Model = model;
        Assembler = assembler;
    }
    public double MaximumSpeed(int potency)
    {
        return potency * 1.75;
    }
}