Car ford = new();
ford.Year = 1999;
ford.ShowData();


public class Car
{
    private int year;
    public int Year
    { 
        get {return year;}
        set
        {
            if (value < 2000)
                year = 2000;
            else if (value > 2022)
                year = 2022;
            else
                year = value;
        }
    }
    public void ShowData()
    {
        System.Console.WriteLine($"Car Year: {Year}");
    }
        
}