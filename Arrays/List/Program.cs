using System.Collections.Generic;

//List<int> numbers = new List<int>();
//numbers = new List<int>();

List<int> numbers = new()
                    {
                        1,2,3
                    };
numbers.Add(4);
numbers.Remove(4);

foreach (var item in numbers)
    System.Console.WriteLine(item);