using System.Reflection;

public class Resume
{
    public string _name = "Allison Rose";
    public List<Job> _jobs = new List<Job>();

    public void DisplayJobList()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");
        foreach (Job j in _jobs)
        {
            j.PrintJobDetails();
        }
    }

}