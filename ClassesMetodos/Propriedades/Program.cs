Product p1 = new();
p1.Name = "Seila";
p1.Price = 4.99;
p1.MinimumStock = 10;

p1.ShowData();


public class Product 
{
    private string? name;
    public string? Name 
    { 
        get { return name.ToUpper(); }
        set { name = value; }
    }
    private double price;
    public double Price 
    { 
        get{ return price; }
        set
        {
             if (value < 5)
                price = 5;
            else 
                price = value;
        }
    }
    private double discount = 0.05;
    public double Discount 
    { 
        get { return discount; }
    }
    public double FinalPrice 
    { 
        get { return Price - (Price * Discount); }
    }
    public double MinimumStock { get; set; }

    public void ShowData()
    {
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"Price: {Price}");
        System.Console.WriteLine($"Discount: {Discount}");
        System.Console.WriteLine($"FinalPrice: {FinalPrice}");
        System.Console.WriteLine($"MinimumStock: {MinimumStock}");
    }

}