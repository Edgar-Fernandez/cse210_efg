public class Event
{
    //Attributes
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;
    private string _type;

    //Constructors
    public Event(string title, string description, string date, string time, Address address, string type)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _type = type;
    }

    //Methods
    public string StandardDetails(string type)
    {
        return $"++++++++++++++ {type} ++++++++++++++\n\nEVENT TITLE: " + _title + "\nDESCRIPTION: " + _description
        + "\nDATE: " + _date + "\nTIME " + _time + "\n" + _address.GetFullAddress() + "\n";
    }
    public string ShortDescription()
    {
        return $"\n++++++++++++++ SHORT DESCRIPTION ++++++++++++++\n\nEVENT TYPE: {GetEventType()}\nTITLE: "
        + GetTitle() + "\nDATE: " + GetDate();
    }
    public string GetTitle()
    {
        return _title;
    }
    public string GetDate()
    {
        return _date;
    }
    public string GetEventType()
    {
        return _type;
    }
}

