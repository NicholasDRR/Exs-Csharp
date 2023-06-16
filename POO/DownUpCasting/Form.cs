namespace _Form;

public class Form
{
    protected int xpos, ypos;
    public Form()
    {}
    public Form(int x, int y)
    {
        xpos = x;
        ypos = y;
    }

    public virtual void Draw()
    {
        System.Console.WriteLine($"Draw in position : {xpos} {ypos}");
    }
    
}