using System.Collections.Generic;

List<string> fruits = new()
{
  "Banana", "Grape", "Pear", "Avocado"
};

var fruit1 = fruits.Find(i => i.StartsWith("G"));
System.Console.WriteLine($"Find: {fruit1}");

var fruit2 = fruits.Find(i => i.Contains("n"));
System.Console.WriteLine($"Find: {fruit2}");

var fruit3 = fruits.FindLast(i => i.Contains("a"));
System.Console.WriteLine($"FindLast: {fruit2}");

var fruit4 = fruits.FindIndex(i => i.Contains("e"));
System.Console.WriteLine($"FindIndex: Indice: {fruit4}, Fruta: {fruits[fruit4]}");

var fruit5 = fruits.FindLastIndex(i => i.Contains("e"));
System.Console.WriteLine($"FindLastIndex: Indice: {fruit5}, Fruta: {fruits[fruit5]}");


var fruits6= fruits.FindAll(i => i.Contains("a"));
System.Console.WriteLine($"FindALL: Fruits with A:");

foreach(var item in fruits6)
    System.Console.Write($"{item} ");



//static bool Search(string item)
//{
//    //return item.Contains("n");
//    return item.ToUpper().StartsWith("G");
//}