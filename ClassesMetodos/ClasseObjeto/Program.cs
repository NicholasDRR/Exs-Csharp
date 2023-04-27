Person p1 = new();
p1.name = "João";
p1.age = 25;
p1.sex = "masculino";

System.Console.WriteLine($"{p1.name} {p1.age} {p1.sex}");

Person p2 = p1;

//Pessoa p2 = new Pessoa();
//p2.nome = "Maria";
//p2.idade = 25;
//p2.sexo = "feminino";

System.Console.WriteLine($"{p2.name} {p2.age} {p2.sex}");


class Person
{
    public string? name;
    public int age;
    public string? sex;
}