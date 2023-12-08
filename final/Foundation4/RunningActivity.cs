public abstract class RunningActivity : Activity
{
    //Attributes
    private double _distance;

    //Constructors
    public RunningActivity(string date, int length, double distance) : base(date, length)
    {
        _distance = distance;
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