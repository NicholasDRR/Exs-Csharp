using _Form;
namespace _Square;

public class Square: Form
{
    public double Side;
    public override double CalculateArea()
    {
        this.Area = Side * Side;
        return Area;
    }
    public override double CalculatePerimeter()
    {
        this.Perimeter = 4 * Side;
        return Perimeter;
    }
}