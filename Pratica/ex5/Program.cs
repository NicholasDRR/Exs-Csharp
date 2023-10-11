using System;
using PersonNamespace;

int total = 3;

Person[] persons = new Person[total];

for (int i = 0; i < total; i++)
{
    persons[i] = new Person(Console.ReadLine());

}

for (int i = 0; i < total; i++)
{
    Console.WriteLine(persons[i].ToString());
}

Console.ReadKey();