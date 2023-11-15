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

    //Methods    
    public abstract void SetGoal();
    public abstract int RecordEvent();
    public abstract string GetStringGoal();
    public abstract string ShowGoal();
    public string ShowGoalSelection()
    {
        return $" {_name}";
    }
    public bool IsCompleted()
    {
        return _completed;
    }
}