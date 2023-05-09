var person = new
{
    Name = "Vitória",
    Age = 19,
    Address = new { Id = 1, City = "Santos", Country = "Brasil"}
};

System.Console.WriteLine($"Name: {person.Name}");
System.Console.WriteLine($"Age: {person.Age}");
System.Console.WriteLine($"City: {person.Address.City}");
System.Console.WriteLine($"Country: {person.Address.Country}");