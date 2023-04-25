Console.WriteLine("Student grade:");
var grade = Convert.ToInt32(Console.ReadLine());

if (grade < 5)
{
    System.Console.WriteLine("Reject student :(");
}
else if (grade >= 5 && grade < 6)
{
    System.Console.WriteLine("Recovery student");
}
else if (grade >= 6 && grade <= 9)
{
    System.Console.WriteLine("Approved student");
}
else
{
    System.Console.WriteLine("Approved student :)");
}