using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");
        //This program created different Exercise Activities
        Console.Clear();
       
        RunningActivity r1 = new RunningActivity("03 Nov 2022",30,4.8);  
        Console.WriteLine(r1.GetSummary());


        
    }
}