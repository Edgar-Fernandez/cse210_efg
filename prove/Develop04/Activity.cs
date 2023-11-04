using System.Reflection.Metadata;

public class Activity
{
    protected string _activityName;
    protected string _description;
    protected int _duration;


    // Constructors

    public Activity(string? name, string? description) // Activity initialization
    {
        _activityName = name;
        _description = description;
    }


    // Methods

    public void DisplayStartingMessage() // Shows starting message, including asking for duration
    {
        string durationStr;
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName}");   
        Console.WriteLine($"\nThis activity will help you {_description}.\n");
        Console.Write($"How long, in seconds, would you like for your session? "); 
        durationStr = Console.ReadLine();
        _duration = int.Parse(durationStr); 
        return;
    }

    public void DisplayEndingMessage() // Shows Well Done! Message, including spiner pauses
    {
        Console.WriteLine("Well done!!!"); 
        SpinnerPause(4);  
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_activityName}."); 
        SpinnerPause(4);  
        return;
    }

    public void SpinnerPause(int seconds)// Shows a spinner for n seconds
    {  
        DateTime startTime = DateTime.Now; // It is NOW
        DateTime endTime = startTime.AddSeconds(seconds); // Sets duration adding seconds to start time

        while (DateTime.Now < endTime)
        {
            string spinner = "|/-\\";
            char[] spinnerChars = spinner.ToCharArray();
            foreach (char c in spinnerChars)
            {
                Console.Write(c);
                Thread.Sleep(250);
                Console.Write("\b \b");
            }
        }
        return;
    }

    public void TimerPause(int seconds) // Shows a timer for n seconds
    {
        // Shows a timer for n seconds
        int duration = seconds;
        DateTime startTime = DateTime.Now; // It is NOW
        DateTime endTime = startTime.AddSeconds(seconds); // Sets duration adding seconds to start time

        while (DateTime.Now < endTime)
        {
            Console.Write(duration);
            Thread.Sleep(1000); // Each pause lasts 1 second
            Console.Write("\b \b");
            duration--;
        }
        return;
    }

    /*public void GetReady() // This is the standard "Get ready..." message behavior (Substituted below)
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        SpinnerPause(5);
        Console.WriteLine();
        return;
    }*/

    public void GetReady() // Enhanced "Get ready..." message. it includes blinking words during animation
    {
        int seconds = 5;
        bool colorFlag = true;
        DateTime startTime = DateTime.Now; // It is NOW
        DateTime endTime = startTime.AddSeconds(seconds); // Sets duration adding seconds to start time        

        while (DateTime.Now < endTime)
        {           
            string spinner = "|/-\\";
            char[] spinnerChars = spinner.ToCharArray();
            foreach (char c in spinnerChars)
            {
                Console.Clear();
                
                if (colorFlag)
                {
                    Console.BackgroundColor = ConsoleColor.DarkYellow;
                    colorFlag = !colorFlag;
                }       
                else
                {
                    Console.BackgroundColor = ConsoleColor.Black;
                    colorFlag = !colorFlag;
                }
                
                Console.Write("Get ready...\n");
                Console.BackgroundColor = ConsoleColor.Black;

                Console.Write(c);
                Thread.Sleep(250);
                Console.Write("\b \b");               
                Console.SetCursorPosition(0, 0);
            }
        }
        Console.SetCursorPosition(0, 2);
    }
}