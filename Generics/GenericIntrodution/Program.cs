//Test test = new();
Test<string, int> test = new();

int i1 = 0;
int i2 = 0;

float f1 = 0;
float f2 = 0;

string s1 = "0";
string s2 = "0";

//test.Compare(i1, f2);
//test.Compare(f1, f2);
//test.Compare(s1, s2);
test.Compare(s1, i2);



Console.ReadKey();
//public class Test
public class Test<T1, T2> where T1 : class where T2 : struct
{
    //public void Compare<T1, T2>(T1 n1, T2 n2)
    public void Compare(T1 n1, T2 n2)
    {
        Console.WriteLine(n1.GetType());
        Console.WriteLine(n2.GetType());
        var result = n1.Equals(n2);
        Console.WriteLine(result);
    }
}
