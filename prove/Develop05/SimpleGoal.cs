public class SimpleGoal : Goal
{
    //Atributes


    //Constructors
    SimpleGoal(string name, string description) : base (name, description)
    {
        _name = name;
        _description = description;
    }

    //Methods    
    public override void SetGoal()
    {

    }
    public override int RecordEvent()
    {
        return 0;
    }
    public override string GetStringGoal()
    {
        return "Simple Goal";
    }
    public override string ShowGoal()
    {
        return "1. Simple Goal";
    }





}