partial class Program
{
    static int Menu()
    {
        int opc;
        Console.Write("1. Buy a product\n2. Exit\nSelect an option: ");
        opc = int.Parse(Console.ReadLine()!);

        return opc;
    }

    static void InventoryManager()
    {
        int opc = Menu();

        if (opc == 1)
        {
            string[] products = ["Monitor", "Mouse", "Keyboard"];
            int[] productsStock = [10, 25, 30];
            double[] prices = [250.50, 20.50, 45.00];

            Console.WriteLine("\n\tProducts inventory:\n------------------------------------\n");
            for (int i = 0; i < products.Length; ++i)
            {
                Console.WriteLine($"Product: {products[i]} | Stock: {productsStock[i]} | Price: {prices[i]:C}");
            }

            string? desiredProduct;
            string? quantity;

            Console.WriteLine("What product would you like to buy?");
            desiredProduct = Console.ReadLine();

            Console.WriteLine("Type the quantity you wish to get");
            quantity = Console.ReadLine();

            if (!int.TryParse(quantity, out int quantityNumber))
            {
                Console.WriteLine("You entered a non-valid quantity");
            }

            for (int i = 0; i < products.Length; ++i)
            {
                if (products[i].Equals(desiredProduct, StringComparison.OrdinalIgnoreCase))
                {
                    if (quantityNumber <= productsStock[i])
                    {
                        double total = quantityNumber * prices[i];
                        productsStock[i] -= quantityNumber;

                        Console.WriteLine($"Successful purchase!\n\tPlease, pay: {total:C}");
                        Console.WriteLine($"\tRemaining stock for the {products[i]} product: {productsStock[i]} units.\n");
                    }
                    else
                    {
                        Console.WriteLine("Not enough stock :/.");
                    }
                }
            }
        }
        else if (opc == 2)
        {
            Console.WriteLine("\nComeback soon!");
        }
        else
        {
            Console.WriteLine("\nInvalid option.");
        }
    }
}