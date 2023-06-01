Nothing nothing = new();

//nothing.Equals();
//nothing.GetHashCode();
//nothing.GetType();
//nothing.ToString();

public class Nothing
{

}

public struct Struct1
{
    
}

public class Class1
{
    
}
public class Class2  : Struct1 // Não é possível herdar de Structs
{

}
public class DerivedClass : Class1, Class2 // Não é possivel herdar de duas classes
{

}