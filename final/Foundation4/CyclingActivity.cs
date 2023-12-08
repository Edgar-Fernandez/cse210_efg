public abstract class CyclingActivity : Activity
{
    //Attributes
    private double _speed;

    //Constructors
    public CyclingActivity(string date, int length, double speed) : base(date, length)
    {
        _speed = speed;
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