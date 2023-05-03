Student student = new("teste", 22, "Fem", "R");

System.Console.WriteLine(student.Name);

public class Student 
{
    public Student(string? name) => Name = name;
    public Student(string? name, int age, string? sex, string? approved):this(name)
    {
        Age = age;
        Sex = sex;
        Approved = approved;
    }

    public string? Name;
    public int Age;
    public string? Sex;
    public string? Approved;
}