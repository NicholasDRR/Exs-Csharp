DerivedClass cd = new();

cd.VerifyAccess();



public class DerivedClass : BaseClass
{
    public void VerifyAccess()
    {
        Public_Member();
        //Private_Member();
        Protected_Member();
        Internal_Member();
        Protected_Internal_Member();
        System.Console.WriteLine("Access to private field");
        int soma = public_var + protected_var + internal_var + Private_var;
        System.Console.WriteLine($"Total soma: {soma}");

    }

}

public class BaseClass
{
    public int public_var = 1;
    protected int protected_var = 2;
    internal int internal_var = 3;
    private int private_var = 4;

    public int Private_var
    {
        get{ return private_var; }
        set{ private_var = value; }
    }

    public void Public_Member()
    {
        System.Console.WriteLine("Base Class - Public Method");
    }
    private void Private_Member()
    {
        System.Console.WriteLine("Base Class - Private Method");
    }
    protected void Protected_Member()
    {
        System.Console.WriteLine("Base Class - Protected Method");
    }
    internal void Internal_Member()
    {   
        System.Console.WriteLine("Base Class - Internal Method");
    }
    protected internal void Protected_Internal_Member()
    {   
        System.Console.WriteLine("Base Class - Protected Internal Method");
    }
}