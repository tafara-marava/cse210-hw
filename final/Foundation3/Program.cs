using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create two orders with user input
        Order order1 = CreateOrderWithUserInput();
        Order order2 = CreateOrderWithUserInput();

        // Display results
        DisplayOrderInformation(order1);
        DisplayOrderInformation(order2);
    }

    static Order CreateOrderWithUserInput()
    {
        // Get product details from the user
        Console.Write("Enter product name: ");
        string productName = Console.ReadLine();

        Console.Write("Enter product ID: ");
        string productId = Console.ReadLine();

        Console.Write("Enter product price: ");
        double productPrice = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter product quantity: ");
        int productQuantity = Convert.ToInt32(Console.ReadLine());

        // Create product
        Product product = new Product(productName, productId, productPrice, productQuantity);

        // Get customer details 
        Console.Write("Enter customer name: ");
        string customerName = Console.ReadLine();

        // Get address 
        Console.Write("Enter street address: ");
        string streetAddress = Console.ReadLine();

        Console.Write("Enter city: ");
        string city = Console.ReadLine();

        Console.Write("Enter state/province: ");
        string state = Console.ReadLine();

        Console.Write("Enter country: ");
        string country = Console.ReadLine();

        // Create address
        Address address = new Address(streetAddress, city, state, country);

        // Create customer
        Customer customer = new Customer(customerName, address);

        // Create order and add product
        Order order = new Order(customer);
        order.AddProduct(product);

        return order;
    }

    static void DisplayOrderInformation(Order order)
    {
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine("\nShipping Label:");
        Console.WriteLine(order.GetShippingLabel());
        Console.WriteLine($"\nTotal Price: ${order.GetTotalPrice()}\n");
    }
}



