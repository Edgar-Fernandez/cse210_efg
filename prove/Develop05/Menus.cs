public class Menus
{
    // Atributes    -->> NO ATTRIBUTES

    // Constructors -->> NO CONSTRUCTORS

    // Methods
    public int DisplayMainMenu(int points) // Displays points and Main Menu. Returns user option.
    {
            string option;
            int optionInt;
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
            return optionInt;
    }
    public int DisplayGoalsMenu() // Displays Goal Type Menu. Returns user option.
    {
        string goalType;
        int goalTypeInt;
        Console.WriteLine("The types of Goals are: ");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of Goal would you like to create? ");
        goalType = Console.ReadLine();
        goalTypeInt = int.Parse(goalType);
        return goalTypeInt;
    }
    public int DisplayEventGoals(List<Goal> goalList) // Diplays Goals List to select one to accomplish. 
    {
        int j = 1;
        string goalAccomp;
        int goalAccompInt;
        Console.WriteLine("The goals are: ");
        foreach (Goal g in goalList)
        {
            Console.Write($"{j}.");
            Console.WriteLine(g.ShowGoalSelection());
            j++;
        }
        Console.Write("Which goal did you accomplish?: ");
        goalAccomp = Console.ReadLine();
        goalAccompInt = int.Parse(goalAccomp);
        return goalAccompInt;
    }
}