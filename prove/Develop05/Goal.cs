using System.ComponentModel.DataAnnotations;

public abstract class Goal
{
    //Atributes
    protected string _name;
    protected string _description;
    protected int _points;
    protected bool _completed;

    //Constructors //
    public Goal(string? name, string? description)
    {
        _name = name;
        _description = description;
        _points = 0;
        _completed = false;
    }

    public Goal(string name, string description, string points, string completed)
    {
        _name = name;
        _description = description;
        _points = int.Parse(points);
        _completed = bool.Parse(completed);
    }

    public Goal(string name, string description, string points, string completed, string times, string timesDone, string bonus)
    {
        _name = name;
        _description = description;
        _points = int.Parse(points);
        _completed = bool.Parse(completed);
    }

    //Methods    
    public abstract void SetGoal();
    public abstract int RecordEvent(int points);
    public abstract string GetStringGoal();
    public abstract string ShowGoal();
    public string ShowGoalSelection()
    {
        return $" {_name}";
    }
    /*public bool IsCompleted()  // Not used. Functionality included in record event method
    {
        return _completed;
    }*/
}