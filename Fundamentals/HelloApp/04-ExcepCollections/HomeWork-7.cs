partial class Program
{
    static void SalesAnalysis()
    {
        List<Sale> sales = new List<Sale> {
            new("Laptop", "Electronic", 1500),
            new("Phone", "Electronic", 900),
            new("Chair", "Furniture", 1200),
            new("Desk", "Furniture", 800),
            new("Tablet", "Electronic", 1300),
            new("Lamp", "Illumination", 400)
        };
        // handle exceptions if any error occurs while processing data
        try
        {
            // filter and show the sales with an amount greater than 1000
            IEnumerable<Sale> salesOver1000 = from s in sales
                                            where s.Amount > 1000
                                            select s;
            WriteLine("\tSales over 1000");
            foreach (Sale sale in salesOver1000)
            {
                WriteLine($"Product: {sale.Product} - Category: {sale.Category} - Amount: {sale.Amount:C}");
            }

            // group the sales by category and calculate the total sales by category
            var totalSalesByCategory = (from s in sales
                                        group s by s.Category into groupedSales
                                        select new
                                        {
                                            Category = groupedSales.Key,
                                            TotalSales = groupedSales.Sum(s => s.Amount)
                                        });
            WriteLine("\n\tTotal sales by category");
            foreach (var sale in totalSalesByCategory)
            {
                WriteLine($"Category: {sale.Category} - Total: {sale.TotalSales:C}");
            }     
        }
        catch (Exception ex)
        {
            WriteLine($"Error: {ex.Message}");
        }
    }
}

class Sale
{
    public string? Product { get; set; }
    public string? Category { get; set; }
    public double Amount { get; set; }

    public Sale(string product, string category, double amount)
    {
        Product = product;
        Category = category;
        Amount = amount;
    }
}