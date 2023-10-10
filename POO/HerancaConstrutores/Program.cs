Student student1 = new();
Student student = new("José");
Console.ReadKey();

public class Person
{
    public Person()
    {
        System.Console.WriteLine("Person builder");
    }
    public Person(string name)
    {
        System.Console.WriteLine("Person builder with Param");
    }
}

public class Student : Person 
{
    public Student(): base()
    {
        System.Console.WriteLine("Student builder");
    }
     public Student(string name): base (name)
    {
        System.Console.WriteLine("Student builder with Param");
    }
}