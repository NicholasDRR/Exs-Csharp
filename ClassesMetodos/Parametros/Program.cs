Student student = new();

System.Console.WriteLine("Student Name:");
student.Name = Console.ReadLine();

System.Console.WriteLine("Student Age:");
student.Age = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Student Sex:");
student.Sex = Console.ReadLine();

System.Console.WriteLine("Student Approved: (Y)es (N)o");
student.Approved = Console.ReadLine();

Course course = new();
course.Result(student);



public class Student 
{
    public string? Name;
    public int Age;
    public string? Sex;
    public string? Approved;
}
public class Course 
{
    public void Result(Student student)
    {
        System.Console.WriteLine($"\nStudent: {student.Name}, sex: {student.Sex}, age: {student.Age}");
        if (student.Approved.ToUpper() == "Y")
            System.Console.WriteLine("Passed! ;)");
        else
            System.Console.WriteLine("Failed :(");
    }
}