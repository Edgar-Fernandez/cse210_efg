public class SwimmingActivity : Activity
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
        return _laps * 50 / 1000;
    }
    public override double GetSpeed()
    {
        return GetDistance() / GetTime() * 60;
    }
    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetTime()} min)- Distance: {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km\n"; ;
    }
}