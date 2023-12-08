public class RunningActivity : Activity
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
        return _distance;
    }
   
    public override double GetSpeed()
    {
        return _distance / GetTime() * 60;
    }
 
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetTime()} min)- Distance: {_distance} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
    }
 
}