public class GatheringEvent : Event
{
    //Attributes
    private string _forecast;

    //Constructors
    public GatheringEvent(string title, string description, string date, string time, Address address, string type, string forecast) : base(title, description, date, time, address, type)
    {
        _forecast = forecast;
    }

    //Methods
    public string FullDetails()
    {
        return StandardDetails("  FULL DETAILS  ") + "EVENT TYPE: " + GetEventType() +
        "\nWEATHER FORECAST: " + _forecast;
    }
}
