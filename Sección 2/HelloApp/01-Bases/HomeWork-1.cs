partial class Program
{
    static void SalesReport()
    {
        string product = "Laptop";
        int quantitySold = 3;
        double unitPrice = 750.99;
        double totalAmount = quantitySold * unitPrice;

        Console.WriteLine($"Product: {product}\nQuantity sold: {quantitySold}\nGrand Total: {totalAmount:C}");
    }

    // Exercise:
    static void SalaryCalculator()
    {
        string? name; //! - ? means it could be null
        double workedHours;
        double hourlyRate;
        double salary;

        Console.WriteLine("\tSalary calculator\n");

        Console.WriteLine("Please, enter your name:");
        name = Console.ReadLine();

        Console.WriteLine("Please, enter the number of hours that you have worked:");
        workedHours = double.Parse(Console.ReadLine()!); //! - ! Null forgiving operator: it means "trust me it's not null"

        Console.WriteLine("Please, enter the hourly rate:");
        hourlyRate = double.Parse(Console.ReadLine()!);

        salary = workedHours * hourlyRate;
        Console.WriteLine($"\tThe salary for {name} is: {salary}");
    }
}