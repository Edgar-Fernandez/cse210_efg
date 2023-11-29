public class Customer
{
    //Attributes
    private string _name;
    private Address _address;

    //Constructors
    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    //Methods
    public bool InUsa()
    {
        if (_address.CountryIsUsa())
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}