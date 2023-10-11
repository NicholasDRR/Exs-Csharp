namespace SquareNamespace;
using System;
using AreaNamespace;


public class Square : ICalculate
{
    public decimal Side { get; set; }

    public Square(decimal side)
	{
        Side = side;
	}
    public decimal CalculateArea()
    {
        return Side * Side;
    }
}
