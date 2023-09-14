using System;

class Program
{
    static void Main(string[] args)
    {
        string name;
        string last_name;
        
        //Console.WriteLine("Hello Prep1 World!");
        Console.Write("What is your first name? ");
        name = Console.ReadLine();

        Console.Write("What is your last name? ");
        last_name = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine($"Your name is {last_name}, {name} {last_name}.");
    }
}