using System;
using SquareNamespace;
using TriangleNamespace;
using CircleNamespace;


Circle circle = new(10);
Console.WriteLine(circle.CalculateArea());

Square square = new(10);
Console.WriteLine(square.CalculateArea());

Triangle triangle = new(10, 10);
Console.WriteLine(triangle.CalculateArea());


Console.ReadKey();