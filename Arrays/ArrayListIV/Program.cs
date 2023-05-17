using System.Collections;

ArrayList list = new()
    	        {
                    "Maria", 1, 4.5
                };

bool contains = list.Contains(1);
bool contains2 = list.Contains(2);

System.Console.WriteLine(contains); // True
System.Console.WriteLine(contains2); // False
System.Console.WriteLine(list.Contains(4.5)); // True

ArrayList numbers = new()
                    {
                        9, 8, 7, 6
                    };
ArrayList names = new()
                    {
                        "Zirso", "Pedro", "Ana"
                    };

numbers.Sort();
names.Sort();

ShowValues(numbers);
// 6 7 8 9
ShowValues(names);
// Ana Pedro Zirso

names.Clear(); // Limpando lista

static void ShowValues(ArrayList list)
{
    if (list.Count == 0)
    {
        System.Console.WriteLine("List has no values");
    }
    else
    {
        for (int i = 0; i < list.Count; i++)
         {
             System.Console.WriteLine(list[i]);
         }
    }
}