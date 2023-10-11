namespace CircleNamespace;

using System;
using AreaNamespace;

public class Circle : ICalculate
{
	public decimal Radius { get; set; }

	public Circle(decimal radius)
	{
		Radius = radius;	
	}

	public decimal CalculateArea()
	{
		return (decimal)Math.PI * (decimal)Radius * (decimal)Radius;
	}
}
