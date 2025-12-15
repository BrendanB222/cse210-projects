using System;

public class Order
{
    public Customer _customer;
    public List<Product> _products = new List<Product>();

    public Order(Customer customer, List<Product> products)
    {
        _customer = customer;
        _products = products;
    }

    public int GetShippingCost()
    {
        if (_customer.GetCountry() == "USA")
        {
            return 5;
        }
        else
        {
            return 35;
        }
    }

    public string CalculateTotalCost()
    {
        int totalCost = 0;

        foreach (Product product in _products)
        {
            totalCost += product.CalculateCost();
        }

        return $"Cost: ${totalCost + GetShippingCost()}";
    }

    public string GetPackingLabel()
    {
        string label = "";

        foreach (Product product in _products)
        {
            label += $"{product.GetLabel()}\n";
        }

        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetAddress();
    }
}