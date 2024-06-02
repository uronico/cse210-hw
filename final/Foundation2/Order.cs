using System;
using System.Collections.Generic;
using System.IO;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public decimal GetTotalPrice()
    {
        decimal totalPrice = 0;

        foreach (var product in _products)
        {
            totalPrice += product.GetTotalCost();
        }

        if (_customer.IsInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";

        foreach (var product in _products)
        {
            packingLabel += $"{product.Name} (Product ID: {product.ProductId}), Quantity: {product.Quantity}\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        return _customer.Address.GetFullAddress();
    }

    public List<Product> Products { get => _products; set => _products = value; }
    public Customer Customer { get => _customer; set => _customer = value; }
}