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
    public double ProductsCost()
    {
        double productsCost = 0;
        foreach (Product product in _products)
        {
            productsCost += product.GetSubtotal();
        }
        return productsCost;
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
        Console.WriteLine("\n************ Packing Label ************\n");
        Console.WriteLine("   PRODUCT\t\tID\t    QTY");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{i}. {product.GetProductName()}\t{product.GetProductId()}\t    {product.GetQuantity()} ");
            i++;
        }
        Console.WriteLine("\n***************************************\n");
        return;
    }
    public void ShippingLabel()
    {
        Console.WriteLine("\n-------------- Shipping Label --------------\n");
        Console.WriteLine($"Ship this order to: {_customer.GetName()}\n");
        Address addressx = _customer.GetAddress();
        Console.WriteLine($"{addressx.GetFullAddress()}");
        Console.WriteLine("\n--------------------------------------------\n");
        return;
    }

    public void TotalPrice()
    {
        int j = 1;
        Console.WriteLine("\n++++++++++++ Order Total Price ++++++++++++\n");
        Console.WriteLine("   QTY\tPRODUCT\t\tPRICE\tSUBTOTAL");
        foreach (Product product in _products)
        {
            Console.WriteLine($"{j}. {product.GetQuantity()}\t{product.GetProductName()}\t{product.GetPrice():0.00}\t{printFormatted("$", product.GetSubtotal())}");
            j++;
        }
        Console.WriteLine($"\t\t\t\t_________");
        Console.WriteLine($"Products Cost =\t\t\t{printFormatted("$", ProductsCost())}");
        Console.WriteLine($"Shipping Cost +\t\t\t{printFormatted("$", ShippingCost())}");
        Console.WriteLine($"\t\t\t\t_________");
        Console.WriteLine($"TOTAL PRICE OF THE ORDER =\t{printFormatted("$", (ProductsCost() + ShippingCost()))}");
        Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++++\n");
        return;
    }

    static string format(string symbol, double amount) // Used for amounts (Adapted from https://stackoverflow.com/questions/36055446/c-sharp-formatting-text-right-align )
    {
        return string.Format("{0,1} {1,7:0.00}", symbol, amount);
    }

    static string printFormatted(string symbol, double amount)
    {
        string result = format(symbol, amount);
        return result;
    }
}