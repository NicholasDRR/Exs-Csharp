namespace _Form;

public abstract class Form 
{   

    public string Color { get; set; } 
    public double Area { get; set; }
    public double Perimeter { get; set;}
    public abstract double CalculateArea();
    public abstract double CalculatePerimeter();

    public void Description()
    {
        System.Console.WriteLine($"Abstract class Form"); 
    }

}


