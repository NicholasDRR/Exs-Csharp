// Exercicio 1 
//string[] fruits = new string []
//                  {
//                    "Maçã",
//                    "Banana",
//                    "Laranja",
//                    "Uva",
//                    "Manga",
//                    "Pêra",
//                    "Abacate",
//                    "Mamão",
//                    "Pêssego",
//                    "Amora"
//                  };
//
//System.Console.WriteLine($"Fruits quantity: {fruits.Length}");
//System.Console.WriteLine($"Penultimate fruit: {fruits[fruits.Length - 1]}");
//System.Console.WriteLine($"Second fruit: {fruits[1]}");
//
//Array.Sort(fruits);
//Array.Reverse(fruits);
//
//
//ShowFruits();
//
//void ShowFruits()
//{
//    foreach (var fruit in fruits)
//    {
//        System.Console.Write($"{fruit}-");
//    }
//}

// Exercicio 2

// ?

// Exercicio 3

//var groups = 2;
//var students = 5;
//
//var grades = new float[groups, students];
//
//
//
//SetData();
//ShowGroup();
//
//void SetData()
//{
//    for (int x = 0; x < groups; x++)
//    {
//        for (int y = 0; y < students; y++)
//        {
//            System.Console.Write($"Group {x+1} Student {y+1}: ");
//            grades[x, y] = float.Parse(Console.ReadLine());
//        }
//    }
//}
//
//void ShowGroup()
//{
//    for (int x = 0; x < groups; x++)
//    {
//        var average = 0.0;
//        System.Console.WriteLine($"\nGroup {x+1}");
//        for (int y = 0; y < students; y++)
//        { 
//            average += grades[x, y] / students;
//            System.Console.WriteLine($"Student {y+1}: {grades[x,y]}");
//        }
//        System.Console.WriteLine($"Average of Group{x+1}: {average.ToString("N2")}");
//    }
//}
//

// Ex 4

//using System.Collections;
//
//ArrayList list = new();
//
//SetData();
//AddPerson("Jaime", 20);
//AddPerson("Tânia", 18);
//list.RemoveAt(list.Count - 1);
//Show(list);
//
//
//void SetData()
//{
//    for(int i = 0; i < 3; i++)
//    {
//        System.Console.Write("Name: ");
//        var name = Console.ReadLine();
//        System.Console.Write("Age: ");
//        int age = Convert.ToInt32(Console.ReadLine());
//
//        AddPerson(name, age);
//    }
//
//}
//void AddPerson(string name, int age)
//{
//    list.Add(new Person
//        {
//            Name = name,
//            Age = age
//        });
//}
//
//void Show(ArrayList list)
//{
//    System.Console.WriteLine("\tPersons\n");
//    foreach (Person person in list)
//    {
//        System.Console.WriteLine($"{person.Name}, {person.Age}");
//    }
//}
//
//
//public class Person
//{
//    public string Name { get; set; } = string.Empty;
//
//    public int Age { get; set; }
//
//    public void ShowData()
//    {
//        System.Console.WriteLine($"Name: {Name}");
//        System.Console.WriteLine($"Age: {Age}");
//    }
//
//}

// Ex 5

//using System.Collections.Generic;
//
//DataSource.AddProducts("Mochila", 22.44M);
//
//var teste = FindObject("Estojo");
//System.Console.WriteLine(teste.Name);
//
//
//
//Product FindObject(string name)
//{
//    var findObject = DataSource.Data().Find(i => i.Name == name);
//    return findObject;
//}
//
//
//void OrderedList(List<Product> list)
//{
//    var orderedList = list.OrderBy(n => n.Name).ToList();
//    ShowInfo(orderedList);
//}
//
//
//List<Product> LessThanFive(List<Product> list)
//{
//    List<Product> lessThanFive = new();
//
//    foreach (var item in list)
//    {
//        if (item.Price < 5)
//        {
//            lessThanFive.Add(item);
//        }
//    }
//    return lessThanFive;
//}
//
//
//void Calculate(List<Product> list)
//{
//    var sum = 0M;
//    foreach (var product in list)
//    {
//        sum += product.Price;
//    }
//    var average = sum / list.Count;
//    System.Console.WriteLine($"Sum of prices: {sum.ToString("C2")}");
//    System.Console.WriteLine($"Average of prices: {average.ToString("C2")}");
//    System.Console.WriteLine($"Quantity of prices: {list.Count}");
//}
//
//
//void ShowInfo(List<Product> list)
//{
//    foreach (var item in list)
//    {
//        System.Console.WriteLine($"{item.Name}\t {item.Price}");
//    }
//}
//
//
//public class DataSource
//{
//    static List<Product> products = new()
//                        {
//                            new Product {Name = "Clips",   Price = 3.95M},
//                            new Product {Name = "Caneta",  Price = 5.99M},
//                            new Product {Name = "Lápis",   Price = 4.15M},
//                            new Product {Name = "Estojo",  Price = 6.99M},
//                            new Product {Name = "Caderno", Price = 7.55M}
//                        };
//    public static List<Product> Data()
//    {
//        return products;
//    }
//    public static void AddProducts(string name, decimal price)
//    {
//        products.Add(new Product {Name = name, Price = price});
//    }
//
//}
//
//public class Product 
//{
//    public string Name { get; set; }
//    public decimal Price { get; set; }
//}

// Exercicio 6

//using System.Collections.Generic;
//
//ProcessObjects(1, "Maria", 3.45m, new Teste(), null);
//
//void ProcessObjects(params object[] vector)
//{
//    foreach(var item in vector)
//    {
//        System.Console.WriteLine($"{item} / {item?.GetType()}");
//    }
//}
//
//class Teste
//{
//
//}

// Exercicio 7

Student student = new();

student[0] = "Jorge";

string value = student[0];

System.Console.WriteLine(value);

public class Student
{
    string[] Names = new string[10];
    public string this[int i]
    {
        get
        {
            if (i >= 0 && i < Names.Length)
            {
                return Names[i];
            }
            return "Error";
        }
        set
        {
            if (i >= 0 && i < Names.Length)
            {
                Names[i] = value;
            }
        }
    }
}
