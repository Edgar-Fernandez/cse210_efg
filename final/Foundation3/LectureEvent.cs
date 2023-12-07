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
        //Console.WriteLine("fULL DETAILS;");
        Console.WriteLine(StandardDetails("  FULL DETAILS  "));
        string capacityStr = _capacity.ToString();
        return $"\nThe Lecture Event will have a capacity of " + capacityStr + " seats \nand the speaker will be "+_speaker;
    }

    public string ShortDescription()
    {
        return $"\nThe Lecture Event \"{GetTitle()}\" will be held on {GetDate()}.";
    }
}
