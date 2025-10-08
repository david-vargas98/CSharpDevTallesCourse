using System.Globalization;

partial class Program
{
    static void ConversionToDateTime()
    {
        // this defines the system's culture
        CultureInfo.CurrentCulture = CultureInfo.GetCultureInfo("en-US");

        int friends = int.Parse("101");
        double cost = 25.50;
        DateTime birthDay = DateTime.Parse("2 March 2025");

        WriteLine($"I have {friends} to invite to my party");
        WriteLine($"The party will be on {birthDay}");
        WriteLine($"The party will be on {birthDay:D} (long format date)");
        WriteLine($"The entrance cost will be: {cost:C}");
    }
}