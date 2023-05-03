Student student = new("Luiz", 22, "M", "Approved");

Console.WriteLine(student.Name == null? "Null value" : student.Name);
Console.WriteLine(student.Age);
Console.WriteLine(student.Sex== null? "Null value" : student.Sex);
Console.WriteLine(student.Approved== null? "Null value" : student.Approved);

public class Student
{
    public Student(string name, int age, string sex, string approved)
    {
        Name = name;
        Age = age;
        Sex = sex;
        Approved = approved;

    }
    public string? Name;
    public int Age;
    public string? Sex;
    public string? Approved;
}