int[] numbers = new int[5] {1,2,3,4,5};

Array.Reverse(numbers);

ShowArray(numbers);

Array.Sort(numbers);

ShowArray(numbers);

System.Console.WriteLine("\nFind an array: ");
System.Console.WriteLine("Number: ");
int number = Convert.ToInt32(Console.ReadLine());

var index = Array.BinarySearch(numbers, number);

if (index >= 0)
    System.Console.WriteLine($"Number: {number} found! Index = {index}");
else
    System.Console.WriteLine($"Number: {number} not found");


static void ShowArray(int[] numbers)
{
    foreach(int number in numbers)
    {
        System.Console.Write($"{number} ");
    }
    System.Console.WriteLine();
}