public abstract class SwimmingActivity : Activity
{
    //Attributes
    private double _laps;

    //Constructors
    public SwimmingActivity(string date, int length, double laps) : base(date, length)
    {
        _laps = laps;
    }

    //Methods
    public override double GetDistance()
    {
        return 1;
    }
   
    public override double GetSpeed()
    {
        return 1;
    }
 
    public override double GetPace()
    {
        return 1;
    }
    public override string GetSummary()
    {
        return "";
    }
 
}