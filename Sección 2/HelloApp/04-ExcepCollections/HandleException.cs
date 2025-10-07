partial class Program
{
    static string? amount;
    static void HandleException()
    {
        try
        {
            // int number = 10;
            // int result = number / 0;

            Write("Enter an amount: ");
            amount = Console.ReadLine();

            if (string.IsNullOrEmpty(amount)) return;

            // handling errors in conversions, intead of 
            if (double.TryParse(amount, out double amountValue))
            {
                WriteLine($"The amount that you have entered is: {amountValue:C}");
            }
            else
            {
                WriteLine("The text couldn't be converted to a number.");
            }
            ValidateAge(16);
            //double amountValue = double.Parse(amount);
        }
        catch (DivideByZeroException)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Error: Division by Zero");
        }
        catch (FormatException) when (amount?.Contains('$') == true)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            WriteLine("Error: It's not necessary to use the '$' (dollar) symbol.");
        }
        catch (Exception ex)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            WriteLine($"Error: {ex.Message}");
        }
        finally
        {
            Console.ResetColor();
            WriteLine("This piece of code will be always executed, no matter what.");
        }
    }

    static void ValidateAge(int age)
    {
        if (age < 18)
        {
            throw new ArgumentException("The age must be greater than 18.");
        }
    }
}