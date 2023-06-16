using _Form;
using _Square;

Square quadrado = new();

System.Console.Write("Square Color: ");
quadrado.Color = Console.ReadLine();

System.Console.Write("Number of Sides: ");
quadrado.Side = Convert.ToDouble(Console.ReadLine());


quadrado.Description();
System.Console.WriteLine($"Color: {quadrado.Color}");
System.Console.WriteLine($"Area: {quadrado.CalculateArea()} m2");
System.Console.WriteLine($"Perimeter: {quadrado.CalculatePerimeter()} m");
