System.Console.WriteLine("Enter the radius:");
double radius = Convert.ToDouble(Console.ReadLine());

Circle circle = new();
double circumference = circle.CalculateAreaPerimeter(radius, out double area);

System.Console.WriteLine($"Area: {area}");
System.Console.WriteLine($"Perimeter: {circumference}");

public class Circle 
{
    public double CalculateAreaPerimeter(double radius, out double area)
    {
        area = Math.Pow(radius, 2) * Math.PI;
        var perimeter = 2 * Math.PI * radius;
        return perimeter;
    }
}