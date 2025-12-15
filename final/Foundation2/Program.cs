using System;

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("123 N Apple St", "Citytropolis", "Alabama", "USA");
        Customer customer = new Customer("John Smith", address);
        List<Product> products1 = new List<Product>();
        Product product1 = new Product("Apple", 36726873, 5, 17);
        products1.Add(product1);
        Product product2 = new Product("Banana", 27863747, 3, 12);
        products1.Add(product2);
        Order order1 = new Order(customer, products1);

        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.CalculateTotalCost());
        Console.WriteLine();

        address = new Address("456 S Maple St", "Metrotown", "Manitoba", "Canada");
        customer = new Customer("Fred William", address);
        List<Product> products2 = new List<Product>();
        product1 = new Product("Cheddar cheese", 83632047, 3, 13);
        products2.Add(product1);
        product2 = new Product("Milk", 37593624, 4, 18);
        products2.Add(product2);
        Order order2 = new Order(customer, products2);

        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.CalculateTotalCost());
        Console.WriteLine();

    }
}