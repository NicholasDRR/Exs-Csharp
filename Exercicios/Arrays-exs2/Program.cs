string[,] students = GetValue();
ShowContent(students);

static string[,] GetValue()
{
    string[,] students = new string[2, 5];

    for (int i = 0; i < students.GetLength(0); i++)
    {
        for (int j = 0; j < students.GetLength(1); j++)
        {
            System.Console.WriteLine($"Value for position: [{i}, {j}]");
            students[i, j] = Console.ReadLine();
        }
    } 
    return students;
}

static void ShowContent(string[,] students)
{
    System.Console.WriteLine("Array Content: ");

    for (int i = 0; i < students.GetLength(0); i++)
    {
        for (int j = 0; j < students.GetLength(1); j++)
        {
            System.Console.WriteLine($"[{i}, {j}] = {students[i,j]}");
        }
    }
}