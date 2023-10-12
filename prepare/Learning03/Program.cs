using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning03 World!");
        //Fraction main program

        //Validate if we can create fractions using constructors

        //Case 1: no parameters
        Fraction fraction1 = new Fraction(); //created with no parameters
        Console.WriteLine(fraction1.GetFractionString());
        Console.WriteLine(fraction1.GetDecimalValue());

        //Case 2: 1 parameter
        Fraction fraction2 = new Fraction(5); //created with 1 parameter
        Console.WriteLine(fraction2.GetFractionString());
        Console.WriteLine(fraction2.GetDecimalValue());

        //Case 3: 2 parameters
        Fraction fraction3 = new Fraction(3, 4); //created with 2 parameters
        Console.WriteLine(fraction3.GetFractionString());
        Console.WriteLine(fraction3.GetDecimalValue());

        //Case 4: Additional value
        Fraction fraction4 = new Fraction(1, 3); //created with 2 parameters
        Console.WriteLine(fraction4.GetFractionString());
        Console.WriteLine(fraction4.GetDecimalValue());

        //Additional code to verify getter and setters
        //NOTE: IT WAS COMMENTED TO HAVE THE SAME OUTPUT AS EXAMPLE INSTRUCTIONS

        /*Fraction fraction5 = new Fraction(); // No parameters
        Console.WriteLine(fraction5.GetFractionString()); //Print default values
        Console.WriteLine(fraction5.GetDecimalValue());
        fraction5.SetTop(3); //Set new top and bottom
        fraction5.SetBottom(4);
        Console.WriteLine(fraction5.GetTop()); //Print new set values
        Console.WriteLine(fraction5.GetBottom());
        Console.WriteLine(fraction5.GetFractionString()); //Call methods with new set values
        Console.WriteLine(fraction5.GetDecimalValue());*/

    }
}