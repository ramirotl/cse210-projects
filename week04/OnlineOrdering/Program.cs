using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("123 Main St", "Springfield", "IL", "USA");
        Customer customer1 = new Customer("John Doe", address1);
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "TEC123", 999.99, 1));
        order1.AddProduct(new Product("Mouse", "TEC234", 25.50, 2));
        order1.AddProduct(new Product("Keyboard", "TEC456", 45.00, 1));

        Console.WriteLine("\nORDER 1 DETAILS:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order1.GetTotalPrice():0.00}");

        Address address2 = new Address("Av. Irala 245", "Santa Cruz de la Sierra", "SCZ", "Bolivia");
        Customer customer2 = new Customer("Jose Vaca", address2);
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("Shoes", "CLT234", 699.99, 1));
        order2.AddProduct(new Product("Shirt", "CLT567", 19.99, 1));
        order2.AddProduct(new Product("Shorts", "CLT789", 89.99, 1));

        Console.WriteLine("\nORDER 2 DETAILS:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"Total Price: ${order2.GetTotalPrice():0.00}");

    }
}