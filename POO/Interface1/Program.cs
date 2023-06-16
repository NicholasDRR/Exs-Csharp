IController demo = new Demo();
demo.Name = "Test";
demo.ShowData();


interface IController
{
    public string Name { get; set; }
    
    void Draw();

    public void ShowData()
    {
        System.Console.WriteLine("...");
    }
}

interface IGraph
{
    void Paint();
}


public class Demo : IController, IGraph
{
    public string? Name { get; set; }

    public void Draw()
    {
        System.Console.WriteLine("Drawing something...");
    }

    public void Paint()
    {
        System.Console.WriteLine("Painting something...");
    }

}