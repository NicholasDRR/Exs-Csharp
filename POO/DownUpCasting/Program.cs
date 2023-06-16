using _Form;
using _Circle;

Circle circle = new();// UPCASTING
Form form = circle;// UPCASTING

//Form circle = new Circle(10, 20); // UPCASTING

if (form is Circle)
{
    var c = form as Circle;// DOWNCASTING
    c.PaintCircle();
    c.Draw();
}
else
{
    System.Console.WriteLine("Unable to downcast");
}
