using System;
using System.IO;
class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop05 World!");
        //Eternal quest program
        string option;
        int optionInt;
        int points = 0;
        List<Goal> goalList = new List<Goal>();

        Console.Clear();
        do
        {
            Console.WriteLine($"You have {points} points\n");   
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6 - Quit");
            Console.Write("Select a choice from the menu: ");
            option = Console.ReadLine();
            optionInt = int.Parse(option);           

            switch(optionInt)
            {
                case 1: 
                    Console.WriteLine("\nOption 1: Create New Goal\n");  
                    string goalType;
                    int goalTypeInt;
                    Console.WriteLine("The types of Goals are: ");
                    Console.WriteLine("1. Simple Goal");
                    Console.WriteLine("2. Eternal Goal");
                    Console.WriteLine("3. Checklist Goal");
                    Console.Write("Which type of Goal would you like to create? ");
                    goalType = Console.ReadLine();
                    goalTypeInt = int.Parse(goalType);

                    //goalList.Add(); 

                    switch(goalTypeInt)
                    {
                        case 1:
                            Console.WriteLine("\nOption 1: Simple Goal\n");

                            //add code here for Simple Goal

                        break;
                        case 2:
                            Console.WriteLine("\nOption 2: Eternal Goal\n");

                            //add code here for Simple Goal

                        break;
                        case 3:
                            Console.WriteLine("\nOption 3: Checklist Goal\n");

                            //add code here for Simple Goal

                        break;
                    }

                break;
                case 2:
                    Console.WriteLine("\nOption 2: List Goals\n");



                break;
                case 3:
                    Console.WriteLine("\nOption 3: Save Goals\n");


                break;
                case 4:
                    Console.WriteLine("\nOption 4: Load Goals\n");


                break;
                case 5:
                    Console.WriteLine("\nOption 5: Record Event\n");


                break;
                case 6:
                    Console.WriteLine("\nThanks for using the Eternal Quest Program!\n");

                break;
            }
        } while (optionInt != 6);
    }
}