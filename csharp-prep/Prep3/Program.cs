using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();

        //string number1;
        string number2;
        int magic;
        int guess;
        int flag = 0;
        int guesses = 1;
        string again = "yes";
        
        //Console.Write("What is the magic number? ");
        //number1 = Console.ReadLine();
        while (again == "yes")
        {
            flag = 0;
            guesses = 1; //We always ask 1 guess
            magic = randomGenerator.Next(1, 11);
            //Console.WriteLine($"The random number is: {magic}"); //Just to check if random is changing

            do{        
            Console.Write("What is your guess? ");
            number2 = Console.ReadLine();
            

                //magic = int.Parse(number1);
                guess = int.Parse(number2);

                if (magic > guess)
                {
                    Console.WriteLine("Higher");
                    guesses++;
                }
                else if (magic < guess)
                {
                    Console.WriteLine("Lower");
                    guesses++;
                }
                else
                {
                    //Console.Write("You guessed it!");
                    Console.WriteLine($"You guessed it! It took you {guesses} guesses to find the magic number.");
                    flag = 1;
                }
            } while (flag == 0);
        Console.Write("Do you want to play again? (yes/no): ");
        again = Console.ReadLine();
        }


    }
}