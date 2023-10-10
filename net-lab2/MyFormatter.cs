using System.Globalization;

namespace net_lab2;

public class MyFormatter
{
    public static string FormatUsdPrice(double price)
    {
        var usc = new CultureInfo("en-us");
        return price.ToString("C2", usc);
    }

    public static string FormatPlnPrice(double price)
    {
        var plc = new CultureInfo("pl-PL");
        return price.ToString("C2", plc);
    }
}