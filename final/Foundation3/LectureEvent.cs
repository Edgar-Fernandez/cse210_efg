public class LectureEvent : Event
{
    //Attributes
    private string _speaker;
    private int _capacity;

    //Constructors
    public LectureEvent(string title, string description, string date, string time, Address address, string speaker, int capacity) : base(title, description, date, time, address)
    { 
        _speaker = speaker;
        _capacity = capacity;
    }

    //Methods
    public string FullDetails()
    {
        return StandardDetails("  FULL DETAILS  ") + "EVENT TYPE: Lecture Event" +
        "\nSPEAKER: " +_speaker + "\nCAPACITY: " + _capacity.ToString() + " seats";
    }

    public string ShortDescription()
    {       
        //return $"\nThe Lecture Event \"{GetTitle()}\" will be held on {GetDate()}.";

        return $"\n++++++++++++++ SHORT DESCRIPTION ++++++++++++++\n\nEVENT TYPE: Lecture event\nTITLE: "
        + GetTitle() +"\nDATE: " + GetDate(); 

    }
}
