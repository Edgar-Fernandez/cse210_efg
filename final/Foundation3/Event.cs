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
    public string StandardDetails(string type)
    {
        return $"++++++++++++++ {type} ++++++++++++++\n\nEVENT: " + _title +"\nDESCRIPTION: " +_description 
        + "\nDATE: "+ _date + "\nTIME " + _time + "\n" + _address.GetFullAddress() + "\n"; 
    }

    public string StandardAddress()
    {
        return _address.GetFullAddress();
    }

    public string GetTitle()
    {       
        return _title;
    }
    public string GetDescription()
    {       
        return _description;
    }
    public string GetDate()
    {       
        return _date;
    }
    public string GetTime()
    {       
        return _time;
    }
}

