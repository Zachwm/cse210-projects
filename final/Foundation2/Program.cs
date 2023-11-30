class zmProgram
{
    static void Main()
    {
        // Create products
        zmProduct zmProduct1 = new zmProduct(1, "Speaker", 20.00);
        zmProduct zmProduct2 = new zmProduct(2, "Printer", 80.00);
        zmProduct zmProduct3 = new zmProduct(3, "Laptop", 1000.00);

        // Create addresses
        zmAddress zmAdress1 = new zmAddress("750 S 2nd E", "Rexburg", "ID", 83440, "USA");
        zmAddress zmAdress2 = new zmAddress("Champ de Mars 5 Av.", "Paris", "7th", 75007,  "Fr.");

        // Create customers
        zmCustomer customer1 = new zmCustomer("Person1", zmAdress1);
        zmCustomer customer2 = new zmCustomer("Person2", zmAdress2);

        // Create orders
        zmOrder zmOrder1 = new zmOrder(customer1);
        zmOrder1.AddProduct(zmProduct1);
        zmOrder1.AddProduct(zmProduct1);
        zmOrder1.AddProduct(zmProduct3);

        zmOrder zmOrder2 = new zmOrder(customer2);
        zmOrder2.AddProduct(zmProduct2);
        zmOrder2.AddProduct(zmProduct3);

        // Display order information
        DisplayOrderInformation(zmOrder1);
        Console.Write("Press enter to continue: ");
        Console.ReadLine();
        DisplayOrderInformation(zmOrder2);
    }

    static void DisplayOrderInformation(zmOrder order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());

        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());

        Console.WriteLine($"\nTotal Price: ${order.GetTotalPrice()}\n");
    }
}