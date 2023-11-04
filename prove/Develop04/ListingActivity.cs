using System.ComponentModel;
using System.Reflection.Metadata;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> //initializing prompts
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?"
    };

    private string _prompt;
    
    
    // Constructors
    public ListingActivity(string? activityName, string? description) : base(activityName, description)// Reflecting activity initialization 
    {
        _activityName = "Listing Activity";
        _description = "reflect on the good things in your life by having you list as many things as you can in a certain area";
        _duration = 0;
    }


    // Methods

    public void RunListingActivity()
    {
        string response;
        int items = 0;

        Console.Clear();
        DisplayStartingMessage();
        GetReady();
        DisplayRandomPrompt();
        //Console.Clear();
        
        DateTime startTime = DateTime.Now; // It is NOW
        DateTime endTime = startTime.AddSeconds(_duration); // Sets duration adding seconds to start time

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            response = Console.ReadLine();  
            items++;     
        }
        
        Console.WriteLine($"You listed {items} items! \n");
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

    public void DisplayRandomPrompt()
    {
        Console.WriteLine("List as many responses you can to the following prompt: ");
        Console.WriteLine($"--- {GetRandomPrompt()}. ---");
        Console.Write("You may begin in: ");
        TimerPause(5);  
        Console.WriteLine();
        return;       
    }
}