using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep5 World!");
        //Functions program
        string name;
        int favorite;
        int squared;

        static void DisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }

        static string PromptUserName()
        {
            string nameFunction;
            Console.Write("Please enter your name: ");
            nameFunction = Console.ReadLine();
            return nameFunction;
        }
        
        static int PromptUserNumber()
        {
            string numberStr;
            int numberFunction;
            Console.Write("Please enter your favorite number:");
            numberStr = Console.ReadLine();
            numberFunction = int.Parse(numberStr);
            return numberFunction;
        }

        static int SquareNumber(int baseNumber)
        {
            int squaredNumber;
            squaredNumber = baseNumber * baseNumber;
            return squaredNumber;
        }

        static void DisplayResult(string name, int squared)
        {
            Console.WriteLine($"{name}, the square of your number is {squared}");
            return;
        }

        DisplayWelcome();
        name = PromptUserName();
        favorite = PromptUserNumber();
        squared = SquareNumber(favorite);
        DisplayResult(name, squared);
        //Console.WriteLine($"Your name is: {name}");
        //Console.WriteLine($"Your favorite number is: {favorite}");
        //Console.WriteLine(squared);


    }
}