using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");
        //Eternal quest program

        /*
        >>> REMEBER TO USE THE METHOD IsCompleted() IT IS IN EACH CLASS
        >>> USE TI TO DESPLAY LIST AND DISPLAY LIST SELECION METHODS
        */

        int option;
        int points = 0;
        List<Goal> goalList = new List<Goal>();
        //string fileName;
        //string[] lines;

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
                    }
                break;
                case 2: // List Goals
                    int i = 1;
                    foreach (Goal g in goalList)
                    {
                        Console.Write($"{i}.");
                        Console.WriteLine(g.ShowGoal());
                        i++;
                    }
                break;
                case 3: // Save Goals
                    files.SaveGoalsFile(goalList, points);
                break;
                case 4: // Load Goals 
                    (goalList, points) = files.LoadGoalsFile();                    
                break;
                case 5: // Record Event  
                    int goalAccomp = menus.DisplayEventGoals(goalList) ;
                    int pointsGotten = goalList[goalAccomp-1].RecordEvent();
                    points+= pointsGotten;
                break;
                case 6: // Quit
                    Console.WriteLine("\nThanks for using the Eternal Quest Program!\n");
                break;
            }
        } while (option != 6);
    }
}