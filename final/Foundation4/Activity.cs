using System.ComponentModel.DataAnnotations;

public abstract class Activity
{
    //Attributes
    private string _date;
    private double _time; // We changed the attribute name "length" for "time" to better understand the formulas 

    //Constructors
    public Activity(string date, double time)
    {
        _date = date;
        _time = time;
    }

    //Methods
    public abstract double GetDistance();

    public abstract double GetSpeed();

    public abstract double GetPace();

    public abstract string GetSummary();

    public string GetDate()
    {
        return _date;
    }
    public double GetTime()
    {
        return _time;
    }
}