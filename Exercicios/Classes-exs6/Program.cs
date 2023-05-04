Car ford = new();
ford.ShowInfo(model:"SUV", carMaker:"Ford", brand:"EcoSport", 200);
ford.ShowInfo(model:"SUV", carMaker:"Ford", brand:"EcoSport", 200, 2013);



public class Car 
{
    public void ShowInfo(string model, string carMaker, string brand, int power, int year=2023)
    {
        System.Console.WriteLine($"\nModel: {model}");
        System.Console.WriteLine($"CarMaker: {carMaker}");
        System.Console.WriteLine($"Brand: {brand}");
        System.Console.WriteLine($"Power: {power}");
        System.Console.WriteLine($"\nYear: {year}");
    }
}