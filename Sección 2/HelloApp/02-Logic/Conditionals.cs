partial class Program
{
    static void Conditionals()
    {
        int age = 19;

        if (age > 18)
        {
            WriteLine("You are of legal age");
        }
        else
        {
            WriteLine("You are minor");
        }

        // ternary if: simplifies conditions
        string message = age >= 18 ? "You are of legal age" : "You are minor";
        WriteLine(message);

        // Multiple conditions: low quantity of conditions
        int temperature = 30;

        if (temperature > 35)
        {
            WriteLine("It's too hot.");
        }
        else if (temperature >= 20)
        {
            WriteLine("It's nice.");
        }
        else
        {
            WriteLine("It's cold.");
        }

        // Switch: for multiple conditions, higher number of conditions
        int day = 3;
        switch (day)
        {
            case 1:
                WriteLine("Monday.");
                break;
            case 2:
                WriteLine("Thursday.");
                break;
            case 3:
                WriteLine("Wednesday.");
                break;
            case 4:
                WriteLine("Tuesday.");
                break;
            case 5:
                WriteLine("Friday.");
                break;
            case 6:
                WriteLine("Saturday.");
                break;
            case 7:
                WriteLine("Sunday.");
                break;
            default:
                WriteLine("It's not a valid day.");
                break;
        }

        // Switch with expressions
        string dayMessage = day switch
        {
            1 => "Monday",
            2 => "Thursday",
            3 => "Wednesday",
            4 => "Tuesday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Not a valid day"
        };
        WriteLine(dayMessage);
    } 
}