using System.Collections.Generic;
using System.Collections;

int[] number = {999};

List<int> numbers = new()
                    {
                        1,2,3,4
                    };


numbers.Add(5);
numbers.Insert(1, 10);
numbers.AddRange(number);
numbers.InsertRange(1, number);
numbers.Remove(5);
numbers.RemoveAt(0);
numbers.RemoveRange(numbers.Count - 1, 1);
numbers.Sort();
//numbers.Clear();

ShowValues(numbers);

bool contains999 = numbers.Contains(999);

if (contains999)
    System.Console.WriteLine("999 exists");
else
    System.Console.WriteLine("999 not exists");


static void ShowValues(List<int> list)
{
    foreach (var item in list)
    System.Console.WriteLine(item);
}
