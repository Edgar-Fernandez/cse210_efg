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

    public void TotalPrice()
    {
        int j = 1;
        //const string format = "${33,8}";
        //double value = 15.1;
        //Console.WriteLine(string.Format(format, value));
        Console.WriteLine("\n+++++++++++ Order Total Price +++++++++++\n");
        Console.WriteLine("   QTY\tPRODUCT\t\tPRICE\tSUBTOTAL");
        foreach (Product product in _products)
        {
            //Console.WriteLine($"{j}. {product.GetQuantity()}\t{product.GetProductName()}\t{product.GetPrice():0.00}\t{product.GetSubtotal():0.00}");
            Console.Write($"{j}. {product.GetQuantity()}\t{product.GetProductName()}\t{product.GetPrice():0.00}\t");
            printFormatted("$",product.GetSubtotal());
            j++;
        }
        Console.WriteLine($"\t\t\t\t________");
        Console.WriteLine($"Products Cost =\t\t\t{ProductsCost():0.00}");
        Console.WriteLine($"Shipping Cost +\t\t\t{ShippingCost():0.00}");
        Console.WriteLine($"\t\t\t\t________");
        Console.WriteLine($"TOTAL PRICE OF THE ORDER =\t{ProductsCost() + ShippingCost():0.00}");
        Console.WriteLine("\n+++++++++++++++++++++++++++++++++++++++++\n");
        return;
    }

    static string format(string description, double cost)
    {
        return string.Format("{0,1} {1,5:0.00}", description, cost);
    }

    static void printFormatted(string description, double cost)
    {
        string result = format(description, cost);
        Console.WriteLine(result);
    }
}