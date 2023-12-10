class Customer
{
    private string name;
    private Address address;

    public Customer(string _name, Address _address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return name;
    }

    public Address GetAddress()
    {
        return address;
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }
}

