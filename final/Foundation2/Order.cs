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
        int i = 1;
        Console.WriteLine("\n*********** Packing Label ***********\n");
        Console.WriteLine("   PRODUCT\t\tID");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{i}. {product.GetProductName()}\t{product.GetProductId()} ");
            i++;
        }   
        Console.WriteLine("\n*************************************\n");
        return;
    }
    public void ShippingLabel()
    {
        Console.WriteLine("\n----------- Shipping Label -----------\n");
        Console.WriteLine($"Ship this order to: {_customer.GetName()}\n");
        Address addressx = _customer.GetAddress();
        Console.WriteLine($"{addressx.GetFullAddress()}");
        Console.WriteLine("\n--------------------------------------\n");
        return;
    }
    public void OrderDetails()
    {
        return;
    }
    public void SetProduct(Product product)
    {
        _products.Add(product);
        return;
    }
}