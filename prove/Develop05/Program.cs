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
        string fileName;
        string[] lines;

        Console.Clear();
        Menus menu = new Menus();

        do
        {
            option = menu.DisplayMainMenu(points);   

            switch(option)
            {
                case 1: // Crete New Goal
                    int goalType;
                    goalType = menu.DisplayGoalsMenu();

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
                    Console.Write("Please enter a name for your file (it should end in \".txt\"): ");
                    fileName = Console.ReadLine();
                    Console.WriteLine($"Saving goals into {fileName} file...");
                    using (StreamWriter outputFile = new StreamWriter(fileName))
                    {  
                        outputFile.WriteLine(points.ToString());
                        foreach (Goal g in goalList)
                        {
                            outputFile.WriteLine(g.GetStringGoal());
                        }                        
                    }
                    Console.WriteLine($"File {fileName} has been created with {goalList.Count} entries.");
                break;
                case 4: // Load Goals 
                    Console.Write("Please enter the name of the file you want to upload: ");
                    fileName = Console.ReadLine();
                    lines = System.IO.File.ReadAllLines(fileName); // FIle is loaded to array lines

                    int k = 0;
                    goalList.Clear(); //Delete any previous Goal List
                    foreach (string line in lines)
                    {
                        if (k == 0) // First line has points
                        {
                            string pointsStr = lines[0];
                            points = int.Parse(pointsStr); // Loads points
                        }
                        else // Other lines have Goals
                        {
                            string[] parts = line.Split(":");
                            string goalType1 = parts[0]; // Gets the Goal Type
                            string goalContent = parts[1]; //Gets the Goal Content
                            string[] goalData = goalContent.Split(","); // Separates goal content

                            switch (goalType1)
                            {
                                case "SimpleGoal":
                                    SimpleGoal newGoal1 = new SimpleGoal(goalData[0], goalData[1], goalData[2], goalData[3]);
                                    goalList.Add(newGoal1);
                                break;
                                case "EternalGoal":
                                    EternalGoal newGoal2 = new EternalGoal(goalData[0], goalData[1], goalData[2], goalData[3]);
                                    goalList.Add(newGoal2);
                                break;
                                case "ChecklistGoal":
                                    ChecklistGoal newGoal3 = new ChecklistGoal(goalData[0], goalData[1], goalData[2], goalData[3], goalData[4], goalData[5], goalData[6]);
                                    goalList.Add(newGoal3);
                                break;
                            }
                        }
                        k++;
                    }
                    Console.Write($"\nGoals have been loaded from file {fileName}\n");

                break;
                case 5: // record Event
                    Console.WriteLine("The goals are: ");
                    int j = 1;
                    string goalAccomp;
                    int goalAccompInt;
                    int pointsGotten;
                    foreach (Goal g in goalList)
                    {
                        Console.Write($"{j}.");
                        Console.WriteLine(g.ShowGoalSelection());
                        j++;
                    }
                    Console.Write("Which goal did you accomplish?: ");
                    goalAccomp = Console.ReadLine();
                    goalAccompInt = int.Parse(goalAccomp);
                    pointsGotten = goalList[goalAccompInt-1].RecordEvent();
                    points+= pointsGotten;
                break;
                case 6: // Quit
                    Console.WriteLine("\nThanks for using the Eternal Quest Program!\n");
                break;
            }
        } while (option != 6);
    }
}