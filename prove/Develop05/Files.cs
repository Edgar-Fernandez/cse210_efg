using System.IO;
public class Files
{
    // Atributes    -->> NO ATTRIBUTES

    // Constructors -->> NO CONSTRUCTORS

    // Methods

    public void SaveGoalsFile(List<Goal> goalList, int points) // Creates a file and saves goals into a specific format. 
    {
        Console.Write("Please enter a name for your file (it should end in \".txt\"): ");
        string fileName = Console.ReadLine();
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
    }

    public (List<Goal>, int) LoadGoalsFile() // Creates a file and saves goals into a specific format. 
    {
        Console.Write("Please enter the name of the file you want to upload: ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName); // FIle is loaded to array lines
        List<Goal> goalList1 = new List<Goal>();
        int points1 = 0;

        int k = 0;
        foreach (string line in lines)
        {
            if (k == 0) // First line has points
            {
                string pointsStr = lines[0];
                points1 = int.Parse(pointsStr); // Loads points
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
                        goalList1.Add(newGoal1);
                    break;
                    case "EternalGoal":
                        EternalGoal newGoal2 = new EternalGoal(goalData[0], goalData[1], goalData[2], goalData[3]);
                        goalList1.Add(newGoal2);
                    break;
                    case "ChecklistGoal":
                        ChecklistGoal newGoal3 = new ChecklistGoal(goalData[0], goalData[1], goalData[2], goalData[3], goalData[4], goalData[5], goalData[6]);
                        goalList1.Add(newGoal3);
                    break;
                }
            }
            k++;
        }
        return (goalList1, points1);
    }

}