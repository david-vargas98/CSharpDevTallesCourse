partial class Program
{
    static void ShowTime()
    {
        DateTime now = DateTime.Now; // gets current date and time
        DateTime today = DateTime.Today; // gets date and time set to 12:00:00 am
        DateTime oneWeekAgo = now.AddDays(-7);
        DateTime customDate = new DateTime(2025, 11, 25);

        // Weekdays
        DayOfWeek weekDay = now.DayOfWeek;

        Console.WriteLine($"Current date and time: {now.ToString()}\nCurrent date: {today.ToString("dd/MM/yyyy")}");
        Console.WriteLine($"One week ago: {oneWeekAgo}");
        Console.WriteLine($"Customized date: {customDate}");
        Console.WriteLine($"Weekday: {weekDay}");
    }
}