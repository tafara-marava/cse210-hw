class Product
{
    private string name;
    private string productId;
    private double price;
    private int quantity;

    public Product(string _name, string _productId, double _price, int _quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    public string GetName()
    {
        return name;
    }

    public string GetProductId()
    {
        return productId;
    }

    public double GetPrice()
    {
        return price * quantity;
    }
}