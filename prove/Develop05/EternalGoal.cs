public class EternalGoal : Goal
{
    //Atributes


    //Constructors
    public EternalGoal(string? name, string? description): base(name, description)
    {
    }

    public EternalGoal(string name, string description, string points, string completed) : base (name, description, points, completed)
    {
    }

    //Methods   

    public override void SetGoal()
    {
        string name;
        string description;
        string points;
        int pointsInt;

        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        points = Console.ReadLine();
        pointsInt = int.Parse(points); 
        _name = name;
        _description = description;
        _points = pointsInt;
    } 
    public override int RecordEvent(int points)
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        Console.WriteLine($"Now you have {points + _points} points!");
        return _points;
    }
    public override string GetStringGoal()
    {
        return $"EternalGoal:{_name},{_description},{_points},{_completed.ToString()}";
    }
    public override string ShowGoal()
    {   
        return $"[ ] {_name} ({_description})";
    }





}