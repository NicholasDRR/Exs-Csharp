using System;
using PersonNamespace;
namespace TeacherNamespace;

public class Teacher: Person
{
    public Teacher(string name) : base(name)
    {
        Name = name;
    }

    public void Explain()
	{
		Console.WriteLine($"The teacher {this.Name} is explaining");
	}
}