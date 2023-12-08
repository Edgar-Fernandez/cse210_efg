public abstract class Activity
{
    //Attributes
    private string _date;
    private int _length;

    //Constructors
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }

    //Methods
    public abstract double GetDistance();
   
    public abstract double GetSpeed();
 
    public abstract double GetPace();

    public abstract string GetSummary();
 
}