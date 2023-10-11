Person person1 = new Person();
Person person2 = new Person();

person1.CPF = 123;
person2.CPF = 123;

Console.WriteLine(person1.GetHashCode());
Console.WriteLine(person2.GetHashCode());
Console.WriteLine(person1.Equals(person2));



Console.ReadKey();


public class Person
{
    public int CPF { get; set; }
    public string Name { get; set; }

    public override bool Equals(object? obj)
    {
        if (obj == null) return false;

        if (!(obj is Person)) return false;

        return CPF.Equals(((Person)obj).CPF);
    }

    public override int GetHashCode()
    {
        return CPF.GetHashCode();
    }

} 