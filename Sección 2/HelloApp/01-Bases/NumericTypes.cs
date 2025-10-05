partial class Program
{
    static void ShowNumericTypes()
    {
        int integerNumber = 42;
        double doubleNumber = 3.1416d; // 64-bit decimal number
        float floatingNumber = 274.5f; //32-bit decimal number (less accurate than double)
        long longNumber = 300200100L; // for long numbers which will be greater than integers
        decimal monetaryNumber = 99.99m; // used for financial calculations (more accurate)
        
        System.Console.WriteLine(
            $"Integer: {integerNumber.GetType()} - {integerNumber}, Double: {doubleNumber.GetType()} - {doubleNumber}, Float: {floatingNumber.GetType()} - {floatingNumber}, Long: {longNumber.GetType()} - {longNumber}, Decimal: {monetaryNumber.GetType()} - {monetaryNumber}");
            


    }
}