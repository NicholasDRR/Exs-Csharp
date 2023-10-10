IController demo = new Demo();
demo.Name = "Test";
demo.ShowData();
Console.ReadKey();


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

   

    public void Paint()
    {
        System.Console.WriteLine("Painting something...");
    }

}