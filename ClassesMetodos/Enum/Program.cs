using Enum;

Console.WriteLine($"\n{WeekDays.Monday} : {(byte)WeekDays.Monday}");
Console.WriteLine($"{WeekDays.Tuesday} : {(byte)WeekDays.Tuesday}");
Console.WriteLine($"{WeekDays.Wednesday} : {(byte)WeekDays.Wednesday}");
Console.WriteLine($"{WeekDays.Thursday} : {(byte)WeekDays.Thursday}");
Console.WriteLine($"{WeekDays.Friday} : {(byte)WeekDays.Friday}");
Console.WriteLine($"{WeekDays.Saturday} : {(byte)WeekDays.Saturday}");
Console.WriteLine($"{WeekDays.Sunday} : {(byte)WeekDays.Sunday}");

Console.WriteLine($"\n{Categories.Fashion} : {(byte)Categories.Fashion}");
Console.WriteLine($"{Categories.Automotive} : {(byte)Categories.Automotive}");
Console.WriteLine($"{Categories.Arts} : {(byte)Categories.Arts}");
Console.WriteLine($"{Categories.Drinks} : {(byte)Categories.Drinks}");
Console.WriteLine($"{Categories.Books} : {(byte)Categories.Books}");
Console.WriteLine($"{Categories.Toys} : {(byte)Categories.Toys}\n");


System.Console.WriteLine("Select a category:");
int value = Convert.ToInt32(Console.ReadLine());

var nameCategory = (Categories)value;

System.Console.WriteLine($"Category: {nameCategory}");


