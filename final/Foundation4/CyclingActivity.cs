public class CyclingActivity : Activity
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
        return _speed / 60 * GetTime();
    }
    public override double GetSpeed()
    {
        return _speed;
    }
    public override double GetPace()
    {
        return 60 / _speed;
    }
    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetTime()} min)- Distance: {GetDistance()} km, Speed: {_speed} kph, Pace: {GetPace()} min per km\n"; ;
    }
}