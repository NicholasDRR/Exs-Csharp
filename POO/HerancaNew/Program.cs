Student student = new();

student.Name = "Julio";
student.Course = "Math";

System.Console.WriteLine(student.Salute());

public class Person
{
    public string? Name { get; set; }
    public string Salute() => $"Hi, I'm {Name}";
}
public class Student : Person
{
    public string? Course { get; set; }
    public new string Salute()
         => $"Hi, I'm {Name} from {Course} course";
}
