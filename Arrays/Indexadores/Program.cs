Team team = new();

team[0] = "teste";
team[1] = "teste1";
team[2] = "teste2";

string test= team[0];
string test1 = team[1];
string test2 = team[999];

System.Console.WriteLine(test);
System.Console.WriteLine(test1);
System.Console.WriteLine(test2);

public class Team
{
    string[] values = new string[10];

    public string this[int i]
    {
        get
        {
            if (i >= 0 && i < values.Length)
            {
                return values[i];
            }
            return "Error";
        }
        set
        {
            if (i >= 0 && i < values.Length)
            {
                values[i] = value;
            }
        }
    }

}