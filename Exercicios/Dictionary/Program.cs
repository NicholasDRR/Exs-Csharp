Dictionary<int, Student> dic = new();


dic.Add(1 ,new Student ("Dina", 5));
dic.Add(2 ,new Student ("Maria", 7));
dic.Add(3 ,new Student ("Eric", 8));
dic.Add(4 ,new Student ("Ana", 9));
dic.Add(5, new Student("Alex", 6));
                                  

foreach (var item in dic)
{
    Console.WriteLine($"{item.Key} => {item.Value.Name} => {item.Value.Grade}");
}

while (true)
{
    Console.WriteLine("Student id (99 to exit):");
    int studentId = Convert.ToInt32(Console.ReadLine());

    if (studentId == 99)
        break;

    bool studentExists = dic.ContainsKey(studentId);

    if (studentExists)
    {
        Console.WriteLine("Enter the new grade: ");
        int studentGrade = Convert.ToInt32(Console.ReadLine());

        dic[studentId].Grade = studentGrade;

        Console.WriteLine("New grade added");
        break;
    }
    else
        Console.WriteLine("Invalid Student");



}

foreach (var item in dic)
{
    Console.WriteLine($"{item.Key} => {item.Value.Name} => {item.Value.Grade}");
}


var orderedlist = dic.OrderBy(x => x.Value.Name);

Console.WriteLine("Ordered list");

foreach (var item in orderedlist)
{
    Console.WriteLine($"{item.Key} => {item.Value.Name} => {item.Value.Grade}");
}



dic.Remove(4);
dic.Add(6, new Student("Vilma", 7));
dic.Clear();


Console.ReadKey();


public class Student
{
    public string? Name { get; set; }
    public int Grade { get; set; }

    public Student(string? name, int grade)
    {
        Name = name;
        Grade = grade;
    }
}