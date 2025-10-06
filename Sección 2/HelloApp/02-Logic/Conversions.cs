partial class Program
{
    static void Conversions()
    {
        // implicit conversions: it occurs when the data type is automatically switched to another one without losing data
        // It happens when we switch from a smaller data type to a bigger data data
        int number = 42;
        double decimalNumber = number;

        WriteLine($"Implicit conversion");
        WriteLine($"number (int): {number} - {number.GetType()}");
        WriteLine($"decimalNumber (double): {decimalNumber} - {decimalNumber.GetType()}");

        // explicit conversions: we need to indicate we're gonna make the conversion (data loss or type incompatibility could happen)
        double explicitDecimalNumber = 42.8;
        int integerNumber = (int)explicitDecimalNumber;
        WriteLine("\nExplicit conversion");
        WriteLine($"explicitDecimalNumber: {explicitDecimalNumber} - {explicitDecimalNumber.GetType()}\n" +
                  $"integerNumber: {integerNumber} - {integerNumber.GetType()} ---> It only keeps the integer part");

        // casting: we use it to transform non related data types such as strings to numbers, we use methods to do it
        WriteLine("\n\tCasting");
        // Convert: it returns 0 when the conversion is not possible
        double decimalNumberTwo = 50.8;
        int decimalConverted = Convert.ToInt32(decimalNumberTwo);
        WriteLine("\nConvert");
        WriteLine($"decimalConverted: {decimalConverted} - type: {decimalConverted.GetType()}");

        // Parsed: it throws an exception when the conversion is not possible 
        string text = "123";
        int parsedNumber = int.Parse(text);
        WriteLine("\nParse");
        WriteLine($"parsedNumber: {parsedNumber} - type: {parsedNumber.GetType()}");
    }
}