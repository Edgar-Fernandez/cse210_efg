public class ChecklistGoal : Goal
{
    //Atributes
    protected int _times;
    protected int _timesDone;
    protected int _bonus;

    //Constructors
    public ChecklistGoal(string? name, string? description): base(name, description)
    {
    }

    public ChecklistGoal(string name, string description, string points, string completed, string times, string timesDone, string bonus) : base (name, description, points, completed)
    {
        _times = int.Parse(times);
        _timesDone = int.Parse(timesDone);
        _bonus = int.Parse(bonus);
    }

    //Methods   

    public override void SetGoal()
    {
        string name;
        string description;
        string points;
        int pointsInt;
        string times;
        int timesInt;
        string bonus;
        int bonusInt;

        Console.Write("What is the name of your goal? ");
        name = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        description = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        points = Console.ReadLine();
        pointsInt = int.Parse(points); 
        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        times = Console.ReadLine();
        timesInt = int.Parse(times); 
        Console.Write("What is the bonus for accomplishing it that many times? ");
        bonus = Console.ReadLine();
        bonusInt = int.Parse(bonus); 
        _name = name;
        _description = description;
        _points = pointsInt;
        _times = timesInt;
        _bonus = bonusInt;
        _timesDone = 0;

    } 
    public override int RecordEvent()
    {
        if (_completed != true)
        {    
            int totalPoints = _points;

            _timesDone++;
            if (_timesDone == _times)
            {
                totalPoints += _bonus;
                _completed = true;
            }
            Console.WriteLine($"Congratulations! You have earned {totalPoints} points!");
            return totalPoints;
        }
                else
        {
            Console.WriteLine($"This goal is already completed. Please select another one.");
            return 0;
        }
    }
    public override string GetStringGoal()
    {
        return $"ChecklistGoal:{_name},{_description},{_points},{_completed.ToString()},{_times.ToString()},{_timesDone.ToString()},{_bonus.ToString()}";
    }
    public override string ShowGoal()
    {
        string compInd = "[ ]"; // Completed indicator
        if (_completed)
        {
            compInd = "[X]";
        }        
        return $"{compInd} {_name} ({_description}) -- Currently completed: {_timesDone.ToString()}/{_times.ToString()}";
    }





}