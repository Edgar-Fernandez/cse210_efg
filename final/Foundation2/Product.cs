public class Product
{
    //Attributes
    private string _name;
    private string _productId;
    private double _price;
    private int _quantity;

    //Constructors
    public Product(string name, string productId, double price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }

    //Methods
    public double GetSubtotal()
    {
        return _price * _quantity;
    }

    public string GetProductName()
    {
        return _name;
    }

    public string GetProductId()
    {
        return _productId;
    }

    public double GetPrice()
    {
        return _price;
    }

    public int GetQuantity()
    {
        return _quantity;
    }
}