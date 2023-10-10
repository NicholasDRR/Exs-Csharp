using System;
using PersonNamespace;
namespace StudentNamespace;

public class Student : Person
{
    public Student(string name) : base(name)
    {
        Name = name;
    }

    public void Studying()
	{
		Console.WriteLine($"The Student {this.Name} is studying");
	}
}