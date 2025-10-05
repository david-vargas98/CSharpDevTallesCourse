using System.Globalization;

partial class Program
{
    static void DaysOfLife()
    {
        DateTime birthDate = new DateTime(1998, 11, 25);
        TimeSpan difference = DateTime.Now - birthDate;
        Console.WriteLine($"You have lived {difference.Days} days");
    }

    // Exercise:
    static void Message(int daysDifference)
    {
        if (daysDifference == 0)
            Console.WriteLine("Today is your birthday!");
        else
            Console.WriteLine($"{daysDifference} days left for your birthday.");
    }
    static void DaysUntilNextBirthday()
    {
        string input;


        Console.WriteLine("Please enter your date of birth (dd/mm/aaaa):");
        input = Console.ReadLine()!;
        if (!DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime birthDate))
        {
            Console.WriteLine("Invalid format or wrong date, please use dd/MM/yyyy");
            return;
        }

        DateTime today = DateTime.Now.Date;
        DateTime birthDateCurrentYear = new(today.Year, birthDate.Month, birthDate.Day);

        if (birthDateCurrentYear >= today)
        {
            int daysDifference = (birthDateCurrentYear - today).Days;
            Message(daysDifference);
        }
        else
        {
            int daysDifference = (birthDateCurrentYear.AddYears(1) - today).Days;
            Message(daysDifference);
        }
    }
}