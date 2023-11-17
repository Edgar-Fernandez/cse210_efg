using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");
        //Eternal quest program

        /* 
            EXCEED CORE REQUIREMENTS
            1. Funtionality was added to set a level for the user based on the number of points earned:
                 0-200 points: Telestial  Level (Magenta color)
               201-400 points: Terrestial Level (Yellow  color)
                >= 401 points: Celestial  Level (Blue    color)
                Levels are also loaded from files and saved to files using only the amount of points.
            2. When user tries to list goals before creating or loading one, an error message appears.
            3. When user tries to create a goals file before creating or loading goals, an error message appears.  
            4. When user loads an empty file, an error message appears (NOTE: Loading empty files clears goals cache)          
            5. User cannot record an event when no goals are created or loaded.
            6. Completed goals can not be completed again. A message is shown when the user tries to 
               record an event for an already completed goal.
        */

        int option;
        int points = 0;
        List<Goal> goalList = new List<Goal>();

        Console.Clear();
        Menus menus = new Menus();
        Files files = new Files();

        do
        {
            option = menus.DisplayMainMenu(points);   

            switch(option)
            {
                case 1: // Crete New Goal
                    int goalType;
                    goalType = menus.DisplayGoalsMenu();

                    switch(goalType)
                    {
                        case 1: // Simple Goal                          
                            SimpleGoal newGoal1 = new SimpleGoal(null, null);
                            newGoal1.SetGoal();
                            goalList.Add(newGoal1);
                        break;
                        case 2: // Eternal Goal
                            EternalGoal newGoal2 = new EternalGoal(null, null);
                            newGoal2.SetGoal();
                            goalList.Add(newGoal2);
                        break;
                        case 3: // Checklist Goal
                            ChecklistGoal newGoal3 = new ChecklistGoal(null, null);
                            newGoal3.SetGoal();
                            goalList.Add(newGoal3);
                        break;
                        default:
                            Console.WriteLine($"\n{goalType} is not a valid goal type.");
                        break;
                    }
                break;
                case 2: // List Goals
                    if (goalList.Count() == 0)
                    {
                        Console.WriteLine("\nNo goals to list. Create one or load a goals file before listing.");
                    }
                    else
                    {
                        int i = 1;
                        Console.WriteLine();
                        foreach (Goal g in goalList)
                        {
                            Console.Write($"{i}.");
                            Console.WriteLine(g.ShowGoal());
                            i++;
                        }
                    }
                break;
                case 3: // Save Goals
                    if (goalList.Count() == 0)
                    {
                        Console.WriteLine("\nNo goals to save. Create one or load a goals file before saving.");
                    }
                    else
                    {
                        files.SaveGoalsFile(goalList, points);
                    }
                break;
                case 4: // Load Goals 
                    (goalList, points) = files.LoadGoalsFile();       
                    if (goalList.Count() == 0)
                    {
                        Console.WriteLine("\nNo goals loaded. Check your file.");
                    }            
                    else
                    {
                        Console.Write($"\n{goalList.Count()} Goals have been loaded.\n");
                    } 
                break;
                case 5: // Record Event  
                    if (goalList.Count() == 0)
                    {
                        Console.WriteLine("\nNo goals to record events. Create one or load a goals file before recording events.");
                    }
                    else
                    {
                        int goalAccomp = menus.DisplayEventGoals(goalList) ;
                        if (goalAccomp < 1 || goalAccomp >= goalList.Count())
                        {
                            Console.WriteLine($"\nGoal No. {goalAccomp} doesn't exist.");
                        }
                        else
                        {
                            int pointsGotten = goalList[goalAccomp-1].RecordEvent(points);
                            points+= pointsGotten;
                        }
                    }
                break;
                case 6: // Quit
                    Console.WriteLine("\nThanks for using the Eternal Quest Program!\n");
                break;
            }
        } while (option != 6);
    }
}