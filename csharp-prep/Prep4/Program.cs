using System;
using System.Transactions;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Prep4 World!");
        //Number List Program
        List<int> numbers = new List<int>();
        List<int> sortedNumbers = new List<int>();
        int next = 0;
        string numberStr;
        int number; 
        double sum = 0; // it was float
        double average; // it was float
        int largest = -99999999;
        int smallest = 99999999;

        Console.WriteLine("Enter a list of numbers, type 0 when finished. ");
        while (next == 0)
        {
            Console.Write("Enter number: ");
            numberStr = Console.ReadLine();
            number = int.Parse(numberStr);
            
            if (number != 0)
            {
                numbers.Add(number);
                sum += number;
                if (number >= largest)
                {
                    largest = number;
                } 
                if (number > 0 && number < smallest)
                {
                    smallest = number;
                }
            }
            else if (number == 0)
            {
                next = 1;
            }
        }
        
        // Print list to check content. 0 should not be included
        /*for (int i = 0; i < numbers.Count; i++ )
        {
            Console.WriteLine(numbers[i]);
        }*/

        average = sum / numbers.Count;
        sortedNumbers = numbers;
        sortedNumbers.Sort();

        Console.WriteLine($"The sum is: {sum}");
        Console.Write("The average is: ");
        Console.WriteLine(average);
        //Console.WriteLine("{0:N2}", average);
        Console.WriteLine($"The largest number is: {largest}");
        Console.WriteLine ($"The smallest positive number is: {smallest}");
        Console.WriteLine("The sorted list is: ");
        for (int i = 0; i < sortedNumbers.Count; i++)
        {
            Console.WriteLine(sortedNumbers[i]);
        }
    }
}