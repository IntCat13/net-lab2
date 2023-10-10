using System.Globalization;

namespace net_lab2;

public class Fruit
{
    public double Price { get; set; }
    public bool IsSweet { get; set; }
    public string Name { get; set; }
    
    public double UsdPrice => Price / UsdCourse.Current;
    
    public static Fruit Create()
    {
        Random r = new Random();
        string[] names = new string[] { "Apple", "Banana", 
            "Cherry", "Durian", "Edelberry", "Grape", "Jackfruit" };
        return new Fruit
        {
            Name = names[r.Next(names.Length)],
            IsSweet = r.NextDouble() > 0.5,
            Price = r.NextDouble() * 10
        };
    }

    public override string ToString()
    {
        CultureInfo us = new CultureInfo("en-US");
        CultureInfo pl = new CultureInfo("pl-PL");
        return $"Fruit: Name={Name}, IsSweet={IsSweet}, Price={MyFormatter.FormatPlnPrice(Price)}, UsdPrice={MyFormatter.FormatUsdPrice(UsdPrice) }";
    }
}