public class Event
{
    //Attributes
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    //Constructors
    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    //Methods
    public string StandardDetails()
    {
        return "Event " + _title +" (" +_description +" )\n"
        + "will be held on "+ _date+" at " +_time + "\n" + _address.GetFullAddress(); // Add suitable code here
    }

    public string StandardAddress()
    {
        return _address.GetFullAddress();
    }
}
