using System;
using System.Collections.Generic;
using System.IO;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public bool IsInUSA()
    {
        return _address.IsInUSA();
    }

    public string Name { get => _name; set => _name = value; }
    public Address Address { get => _address; set => _address = value; }
}


