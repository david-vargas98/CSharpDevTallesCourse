partial class Program
{
    static void DataTypes()
    {
        Console.WriteLine("DataTypes");

        int integer = 42;
        double decimalNumber = 3.1416;
        bool isTrue = true;
        char character = 'C';
        string text = "Hello C#";

        System.Console.WriteLine(
            $"Integer: {integer}, Decimal: {decimalNumber}, Boolean: {isTrue}, Character: {character}, Text: {text}");
    }
}