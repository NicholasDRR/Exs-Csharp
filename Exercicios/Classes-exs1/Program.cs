Car chevrolet = new("Sedan", "Chevrolet" , "Onix", 2016, 110);
Car ford = new("SUV", "Ford", "EcoSport", 2018, 120);

Console.WriteLine($"\n\nModel: {chevrolet.Model} ");
Console.WriteLine($"Assembler: {chevrolet.Assembler} ");
Console.WriteLine($"Brand: {chevrolet.Brand} ");
Console.WriteLine($"Year: {chevrolet.Year} ");
Console.WriteLine($"Power: {chevrolet.Power} ");
chevrolet.Accelerate(chevrolet.Brand);


Console.WriteLine($"\n\nModel: {ford.Model} ");
Console.WriteLine($"Assembler: {ford.Assembler} ");
Console.WriteLine($"Brand: {ford.Brand} ");
Console.WriteLine($"Year: {ford.Year} ");
Console.WriteLine($"Power: {ford.Power} ");
ford.Accelerate(ford.Brand);



public class Car {
    public string Model;
    public string Assembler;
    public string Brand;
    public int Year;
    public int Power;
    public void Accelerate(string brand)
    {
        System.Console.WriteLine("Accelerating my " + brand);
    }
    public Car(string model, string assembler, string brand, int year, int power)
    {
        this.Model = model;
        this.Assembler = assembler;
        this.Brand = brand;
        this.Year = year;
        this.Power = power;
    }
    
}
