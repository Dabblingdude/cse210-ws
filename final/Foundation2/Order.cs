using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    public decimal GetTotalCost()
    {
        decimal total = 0;

        foreach (var product in _products)
        {
            total += product.GetProductTotalPrice();
        }

        total += _customer.LivesInUS() ? 5 : 35;

        return total;
    }

    public string GetPackingLabel()
    {
        string label = "Packing List:\n";

        foreach (var product in _products)
        {
            label += $"- {product.GetProductInfo()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return $"Shipping to:\n{_customer.GetCustomerInfo()}";
    }

    public void DisplayOrderSummary()
    {
        Console.WriteLine(GetPackingLabel());
        Console.WriteLine(GetShippingLabel());
        Console.WriteLine($"Total Cost: ${GetTotalCost():F2}");
        Console.WriteLine(new string('-', 40));
    }
}