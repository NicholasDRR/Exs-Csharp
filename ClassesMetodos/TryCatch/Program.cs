System.Console.WriteLine("X value: ");
int x = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Y value:");
int y = Convert.ToInt32(Console.ReadLine());
 

try
{
    int z = x / y;
    System.Console.WriteLine($"\n{x} / {y} = {z}");
}
catch (Exception ex)
{
    System.Console.WriteLine("Cannot divide by 0");
    System.Console.WriteLine($"\nError: <<< {ex.Message} >>>");
    System.Console.WriteLine($"\nDetalhes: <<< {ex?.StackTrace?.ToString()} >>>");
}
finally
{
    System.Console.WriteLine("\nProcessing complete!");
}
