using _Form;
namespace _Circle;

public class Circle : Form
{
    public Circle()
    {}

    public Circle(int x, int y): base(x,y)
    {}

    public override void Draw()
    {
        System.Console.WriteLine($"Draw in position : {xpos} {ypos}");
    }

    public void PaintCircle()
    {
        System.Console.WriteLine("Painting the circle");
    }
}

