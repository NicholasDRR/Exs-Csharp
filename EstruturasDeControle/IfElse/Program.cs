System.Console.WriteLine("Enter the student's grade:");
var grade = Convert.ToDouble(Console.ReadLine());

if (grade > 5)
{
    System.Console.WriteLine("Student Approved!");
}
else
{
    System.Console.WriteLine("Student Failed!");
}

System.Console.WriteLine("\nX value:");
var x = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Y value:");
var y = Convert.ToInt32(Console.ReadLine());

if (x > y)
{
    System.Console.WriteLine("X is bigger than Y");
}
else
{
     if (x < y)
     {
        System.Console.WriteLine("X is smaller than Y");
     }
     else
     {
        System.Console.WriteLine("X equals Y");
     }
}
