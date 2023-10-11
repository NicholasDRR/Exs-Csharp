namespace TriangleNamespace;

using System;
using AreaNamespace;


public class Triangle : ICalculate
{
    public decimal Base { get; set; }
    public decimal Height { get; set; }

    public Triangle(decimal height, decimal baseTriangle)
	{
        Base = baseTriangle;
        Height = height;
	}

    public decimal CalculateArea()
    {
        return (Base * Height) / 2;
    }
}
