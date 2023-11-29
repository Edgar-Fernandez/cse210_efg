public class Order
{
    //Attributes
    private List<Product> _products;
    private Customer _customer;

    //Constructors
    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    //Methods
    public double TotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.GetSubtotal();
        }   
        return totalCost;
    }
    public int ShippingCost()
    {
        int shippingCost;
        if (_customer.InUsa())
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return shippingCost;
    }
    public void Packinglabel()
    {
        return;
    }
    public void ShippingLabel()
    {
        return;
    }
    public void OrderDetails()
    {
        return;
    }
    public void SetProduct()
    {
        return;
    }
}