using System.Collections;

Generic<int> generic = new();

generic.AddV(1);
generic.AddV(2);
generic.AddV(3);
generic.AddV(4);
generic.AddV(5);
generic.AddV(6);

Console.WriteLine(generic.GetType());
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(generic[i]);

}

Generic<string> generic2 = new();

generic2.AddV("1");
generic2.AddV("2");
generic2.AddV("3");
generic2.AddV("4");
generic2.AddV("5");
generic2.AddV("6");

Console.WriteLine(generic2.GetType());
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(generic2[i]);
}


Generic<bool> generic3 = new();

generic3.AddV(true);
generic3.AddV(true);
generic3.AddV(true);
generic3.AddV(false);
generic3.AddV(false);
generic3.AddV(false);

Console.WriteLine(generic3.GetType());
for (int i = 0; i < 5; i++)
{
    Console.WriteLine(generic3[i]);
}


Console.ReadKey();


public class Generic<T>
{
    public T[] list = new T[5];
    int count = 0;

    public void AddV(T TValue)
    {
        if (count < 5)
        {
           list[count] = TValue;
        }
        count++;
    }

    public T this [int index]
    {
        get { return list[index]; }
        set { list[index] = value; }
    }


}