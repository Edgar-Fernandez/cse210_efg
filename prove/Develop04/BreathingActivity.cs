using System.ComponentModel;
using System.Reflection.Metadata;

public class BreathingActivity : Activity
{
    // This class has no atributes


    // Constructors

    /*public BreathingActivity() // 
    {
        _activityName = "";
        _description = "";
        _duration = 0;
    }*/

    public BreathingActivity(string activityName, string description, int duration) : base(activityName, description, duration)// Breathing activity initialization
    
    {
        _activityName = "Breathing Activity";
        _description = "relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
        _duration = 0;
    }


    // Methods

    public void RunBreathingActivity()
    {
        Console.Clear();
        DisplayStartingMessage();
        GetReady();
        
        DateTime startTime = DateTime.Now; // It is NOW
        DateTime endTime = startTime.AddSeconds(_duration); // Sets duration adding seconds to start time

        while (DateTime.Now < endTime)
        {
            Breath();
        }
        
        
        //Breath();

        
        DisplayEndingMessage();

        return;
    }

    public void Breath()
    {
        Console.Write("Breathe in...");
        TimerPause(4);
        Console.Write("\nNow breathe out...");
        TimerPause(7);
        Console.WriteLine("\n");
        return;
    }

}