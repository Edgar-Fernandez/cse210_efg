using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep2 World!");
        string stringPercentage;
        int numberPercentage;
        string letter = "X"; // Initialized to avoid "Use of unassigned local variabe 'letter' error.
        string sign;
        float remainder;
        
        Console.Write("Please enter your grade percentage: ");
        stringPercentage = Console.ReadLine();
        numberPercentage = int.Parse(stringPercentage);

        if (numberPercentage >= 90)
        {
            //Console.WriteLine("Your grade is A");
            letter = "A";
        }
        else if (numberPercentage >= 80)
        {
            //Console.WriteLine("Your grade is B");
            letter = "B";
        }
        else if (numberPercentage >= 70)
        {
            //Console.WriteLine("Your grade is C");
            letter = "C";
        }
        else if (numberPercentage >= 60)
        {
            //Console.WriteLine("Your grade is D");
            letter = "D";
        }
        else if (numberPercentage < 60)
        {
            //Console.WriteLine("Your grade is F");
            letter = "F";
        }

        // Calculate sign
        remainder = numberPercentage % 10;

        if (remainder >= 7)
        {
            sign = "+";
        }
        else if (remainder < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // A and F have no sign
        if (letter == "A" || letter == "F")
        {
            sign = "";
        }


        Console.WriteLine($"Your grade is {letter}{sign}");

        if (numberPercentage >= 70)
        {
            Console.WriteLine("Congratulations!!! You approved the course!!!");
        }
        else
        {
            Console.WriteLine("You failed the course. Good luck next time.");
        }

    }
}