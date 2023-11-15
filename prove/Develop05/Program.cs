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
        string option;
        int optionInt;
        int points = 0;
        List<Goal> goalList = new List<Goal>();
        string fileName;
        string[] lines;

        Console.Clear();
        do
        {
            Console.WriteLine($"\nYou have {points} points\n");   
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();
            optionInt = int.Parse(option);           

            switch(optionInt)
            {
                case 1: // Crete New Goal
                    string goalType;
                    int goalTypeInt;
                    Console.WriteLine("The types of Goals are: ");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Which type of Goal would you like to create? ");
                    goalType = Console.ReadLine();
                    goalTypeInt = int.Parse(goalType);

                    switch(goalTypeInt)
                    {
                        case 1: // Simple Goal                          
                            SimpleGoal newGoal1 = new SimpleGoal(null, null);
                            newGoal1.SetGoal();
                            goalList.Add(newGoal1);
                            /*Console.WriteLine(newGoal1.GetStringGoal());
                            Console.ReadLine();

                            Console.WriteLine(goalList[0].GetStringGoal());
                            Console.ReadLine();
                            Console.WriteLine(goalList[0].ShowGoal());
                            Console.ReadLine();*/
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
                    //NOTE: Loading a file deletes any existing goals in the "buffer" goalList
                    goalList.Clear(); //Delete any previous journal
                    Console.Write("Please enter the name of the file you want to upload: ");
                    fileName = Console.ReadLine();
                    lines = System.IO.File.ReadAllLines(fileName);

                    foreach (string line in lines)
                    {
                        //goalList.Add(line); // need to convert text in object
                    }
                    Console.Write($"\nJournal has been loaded from file {fileName}");

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
        } while (optionInt != 6);
    }
}