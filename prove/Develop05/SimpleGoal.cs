public class SimpleGoal : Goal
{
    //Atributes


    //Constructors
    public SimpleGoal(string? name, string? description): base(name, description)
    {
    }

    public SimpleGoal(string name, string description, string points, string completed) : base (name, description, points, completed)
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
        if (_completed != true)
        {
            _completed = true;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            Console.WriteLine($"Now you have {points + _points} points!");
            return _points;
        }
        else
        {
            Console.WriteLine($"This goal is already completed. Please select another one.");
            return 0;
        }
    }
    public override string GetStringGoal()
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_completed.ToString()}";
    }
    public override string ShowGoal()
    {
        string compInd = "[ ]"; // Completed indicator
        if (_completed)
        {
            compInd = "[X]";
        }
        return $"{compInd} {_name} ({_description})";
    }
}