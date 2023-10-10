using System;
using PersonNamespace;
using TeacherNamespace;
using StudentNamespace;

int total = 3;
Person[] person = new Person[total];

for (int i = 0; i < total; i++)
{
    if (i == 0)
    {
        Console.WriteLine("Teacher Name: ");
        person[i] = new Teacher(Console.ReadLine());
    }
    else
    {
        Console.WriteLine("Student Name: ");
        person[i] = new Student(Console.ReadLine());
    }
    
}

for (int i = 0; i < total; i++)
{
    if (i == 0)
    {
        Console.WriteLine("Teacher:");
        ((Teacher)person[i]).Explain();
    }
    else
    {
        Console.WriteLine("Teacher:");
        ((Student)person[i]).Studying();
    }

}


//Person person = new("joao");
//Console.WriteLine(person.Name);

//Teacher teacher = new("Jozias");
//Console.WriteLine(teacher.Name);

//Student student = new("Incrivel");
//Console.WriteLine(student.Name);

Console.ReadKey();