DerivedClass derived = new();
derived.Name = "John";
System.Console.WriteLine(derived.ShowName);




sealed class BaseClass
{
    public string? Name { get; set; }
    public string? ShowName => $"My name is {Name}";
}
public class DerivedClass : BaseClass
{
    public new string ShowName => $"My name is {Name}";
}

public class BaseClass
{

    protected virtual void Method1()
    {
        System.Console.WriteLine("Base Class Method 1");
    }

    protected virtual void Method2()
    {
        System.Console.WriteLine("Base Class Method 2");
    }

}
public class DerivedClass : BaseClass
{
     sealed protected override void Method1()
    {
        System.Console.WriteLine("Derived Class Method 1");
    }
    
    protected override void Method2()
    {
        System.Console.WriteLine("Derived Class Method 2");
    }
}
public class DerivedClass2 : DerivedClass
{
    // Tentar sobrescrever causa um erro CS0239
     protected override void Method1()
    {
        System.Console.WriteLine("Derived Class Method 1");
    }
}