using System;
using System.Collections.Generic;

class Address
{
    public string Street { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }

    public Address(string street, string city, string state, string country)
    {
        Street = street;
        City = city;
        State = state;
        Country = country;
    }

    public bool IsInUSA()
    {
        return Country.Equals("USA", StringComparison.OrdinalIgnoreCase);
    }

    public string GetFullAddress()
    {
        return $"{Street}\n{City}, {State}\n{Country}";
    }
}

class Product
{
    public string Name { get; set; }
    public int ProductId { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, int productId, decimal price, int quantity)
    {
        Name = name;
        ProductId = productId;
        Price = price;
        Quantity = quantity;
    }

    public decimal GetTotalCost()
    {
        return Price * Quantity;
    }
}

class Customer
{
    public string Name { get; set; }
    public Address CustomerAddress { get; set; }

    public Customer(string name, Address address)
    {
        Name = name;
        CustomerAddress = address;
    }

    public bool LivesInUSA()
    {
        return CustomerAddress.IsInUSA();
    }
}

class Order
{
    public List<Product> Products { get; set; }
    public Customer OrderCustomer { get; set; }
    private const decimal ShippingCostUSA = 5.00m;
    private const decimal ShippingCostInternational = 35.00m;

    public Order(Customer customer)
    {
        Products = new List<Product>();
        OrderCustomer = customer;
    }

    public void AddProduct(Product product)
    {
        Products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal totalProductCost = 0;

        foreach (var product in Products)
        {
            totalProductCost += product.GetTotalCost();
        }

        decimal shippingCost = OrderCustomer.LivesInUSA() ? ShippingCostUSA : ShippingCostInternational;
        return totalProductCost + shippingCost;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";

        foreach (var product in Products)
        {
            packingLabel += $"{product.Name} (ID: {product.ProductId})\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return $"Shipping Label:\n{OrderCustomer.Name}\n{OrderCustomer.CustomerAddress.GetFullAddress()}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        Address address = new Address("101 E Viking St", "Rexburg", "ID", "USA");
        Customer customer = new Customer("BYUI", address);
        Order order = new Order(customer);

        order.AddProduct(new Product("Hopefully new markers for the Math tutor lab", 101, 3.00m, 5));
        order.AddProduct(new Product("Hopefully faucets like the ETC ones but for the STC", 102, 5.00m, 3));
        order.AddProduct(new Product("A giant wheel of cheese.", 103, 10.00m, 2));

        decimal totalCost = order.GetTotalCost();
        Console.WriteLine($"Total Cost: ${totalCost:F2}");

        Console.WriteLine(order.GetPackingLabel());
        Console.WriteLine(order.GetShippingLabel());
    }
}
