public class ReceptionEvent : Event
{
    //Attributes
    private string _rsvpEmail;

    //Constructors
    public ReceptionEvent(string title, string description, string date, string time, Address address, string rsvpEmail) : base(title, description, date, time, address)
    { 
        _rsvpEmail = rsvpEmail;
    }

    //Methods
    public string FullDetails()
    {
        return StandardDetails("  FULL DETAILS  ") + "EVENT TYPE: Reception Event" +
        "\nRSVP Email: " +_rsvpEmail;
    }

    public string ShortDescription()
    {       
        return $"\n++++++++++++++ SHORT DESCRIPTION ++++++++++++++\n\nEVENT TYPE: Reception event\nTITLE: "
        + GetTitle() +"\nDATE: " + GetDate(); 
    }
}
