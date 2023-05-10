string[] names = new string[5];
double[] grades = new double[5];

System.Console.WriteLine(" Students ");

for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine("Student name: ");
    string? name = Console.ReadLine();
    names[i] = name;
}

for (int i = 0; i < 5; i++)
{
    System.Console.WriteLine("Student grade: ");
    double grade = Convert.ToDouble(Console.ReadLine());
    grades[i] = grade;
}

foreach (string name in names)
{
    System.Console.Write($"{name}  ");
}

var sumGrade = 0;
var totGrades = grades.Count();

System.Console.WriteLine();
foreach (int grade in grades)
{
    sumGrade += grade;
    System.Console.Write($"{grade}  ");
}

System.Console.WriteLine($"\nAverage: {sumGrade / totGrades}");