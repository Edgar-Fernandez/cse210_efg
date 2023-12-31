using System.ComponentModel;
using System.Reflection.Metadata;

public class ReflectingActivity : Activity
{
    private List<string> _prompts = new List<string> // Initializing prompts
    {
        "Think of a time when you stood up for someone else",
        "Think of a time when you did something really difficult",
        "Think of a time when you helped someone in need",
        "Think of a time when you did something truly selfless"
    };
    private List<string> _questions = new List<string> // Initializing questions
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?"
    };
    private string _prompt;
    private string _question;


    // Constructors
    public ReflectingActivity(string? activityName, string? description) : base(activityName, description)// Reflecting activity initialization  
    {
        _activityName = "Reflecting Activity";
        _description = "reflect on times in your life when you have shown strength and resilence. This will help you recognize the power you have and how you can use it in other aspects of your life";
        _duration = 0;
    }


    // Methods

    public void RunReflectingActivity()
    {
        Console.Clear();
        DisplayStartingMessage();
        GetReady();
        DisplayRandomPrompt();
        Console.Clear();
        
        DateTime startTime = DateTime.Now; // It is NOW
        DateTime endTime = startTime.AddSeconds(_duration); // Sets duration adding seconds to start time

        while (DateTime.Now < endTime)
        {
            DisplayRandomQuestion();         
        }
        
        Console.WriteLine();
        DisplayEndingMessage();
        return;
    }

    public string GetRandomPrompt()
    {
        Random randomIndex = new Random();
        int index = randomIndex.Next(0,_prompts.Count);
        _prompt = _prompts[index];        
        return _prompt;
    }

    public string GetRandomQuestion()
    {
        Random randomIndex = new Random();
        int index = randomIndex.Next(0,_questions.Count);
        _question = _questions[index];      
        return _question;
    }

    public void DisplayRandomPrompt()
    {
        Console.WriteLine("Consider the following prompt: \n");
        Console.WriteLine($"--- {GetRandomPrompt()}. ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue. ");
        Console.ReadLine();
        Console.WriteLine("Now ponder in each of the following questions as they related to this experience. ");
        Console.Write("You may begin in: ");
        TimerPause(5);  
        return;   
    }

    public void DisplayRandomQuestion()
    {
        Console.Write($"> {GetRandomQuestion()} ");
        SpinnerPause(7);
        Console.WriteLine();
    }
}