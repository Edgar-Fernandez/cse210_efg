public class ReceptionEvent : Event
{
    //Attributes
    private string _rsvpEmail;

    //Constructors
    public ReceptionEvent(string title, string description, string date, string time, Address address, string type, string rsvpEmail) : base(title, description, date, time, address, type)
    {
        _rsvpEmail = rsvpEmail;
    }

    //Methods
    public string FullDetails()
    {
        return StandardDetails("  FULL DETAILS  ") + "EVENT TYPE: " + GetEventType() +
        "\nRSVP EMAIL: " + _rsvpEmail;
    }
}
