public class Address
{
    //Attributes
    private string _street;
    private string _city;
    private string _stateProvince;
    private string _country;

    //Constructors
    public Address(string street, string city, string stateProvince, string country)
    {
        _street = street;
        _city = city;
        _stateProvince = stateProvince;
        _country = country;
    }

    //Methods
    public string GetFullAddress()
    {
        return "ADDRESS: "+ _street + ", " + _city + ",\n"  
        + _stateProvince + ", " + _country + ".";
    }
}