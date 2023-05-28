using studentcs;
using datasourcecs;
using System.Collections.Generic;

List<Student> students = DataSource.GetStudents();

AddStudents("Bia", 7.75);
AddStudents("Mario", 8.95);

RemoveStudentsByName("Amanda");

ShowData(OrderedList());
ShowData(PassedStudent());



List<Student> PassedStudent()
{
    List<Student> passedStudent = new();
    foreach (var student in students)
    {
        if (student.Grade >= 8)
        {
            passedStudent.Add(student);
        }
    }
    return passedStudent;
}

List<Student> OrderedList()
{
    var orderedStudents = students.OrderBy(n => n.Name).ToList();
    return orderedStudents;
}

void RemoveStudentsByName(string name)
{
    var student = students.Find(n => n.Name.Equals(name));
    students.Remove(student);
}

void AddStudents(string name, double grade)
{
    students.Add(new Student {Name = name, Grade  = grade});
}

void ShowData(List<Student> list)
{
    var average = 0.0;
    System.Console.WriteLine("STUDENTS:\n");
    foreach (var student in list)
    {
        average += student.Grade;
        System.Console.WriteLine($"Name: {student.Name}\t Grade: {student.Grade}");
    }
    System.Console.WriteLine($"\nDATA:\n");
    System.Console.WriteLine($"Average grade: {Math.Round(average, 2)}");
    System.Console.WriteLine($"Students count: {list.Count}");
}

