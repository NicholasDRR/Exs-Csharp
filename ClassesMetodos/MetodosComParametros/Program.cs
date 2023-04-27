Day today = new();

today.ShowDay(27);
today.ShowMonth(04);
today.ShowYear(2023);


class Day
{
    public void ShowDay(int day) =>
        System.Console.WriteLine($"Today is day: {day}");
    public void ShowMonth(int month) =>
        System.Console.WriteLine($"Today is month: {month}");
    public void ShowYear(int year) =>
        System.Console.WriteLine($"Today is year: {year}");
    
}