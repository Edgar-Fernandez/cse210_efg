public class LectureEvent : Event
{
    //Attributes
    private string _speaker;
    private int _capacity;

    //Constructors
    public LectureEvent(string title, string description, string date, string time, Address address, string type, string speaker, int capacity) : base(title, description, date, time, address, type)
    {
        _speaker = speaker;
        _capacity = capacity;
    }

    //Methods
    public string FullDetails()
    {
        return StandardDetails("  FULL DETAILS  ") + "EVENT TYPE: " + GetEventType() +
        "\nSPEAKER: " + _speaker + "\nCAPACITY: " + _capacity.ToString() + " seats";
    }
}
