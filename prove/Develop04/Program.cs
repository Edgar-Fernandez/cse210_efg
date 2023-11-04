using System;
using System.Reflection.Metadata;

/*
*****************************************************************
SHOWING CREATIVITY AND EXCEEDING REQUIREMENTS

1. I added a log of how many times activities were performed, which
   is shown at the end of the session.
2. I enhanced the "Get ready..." behavior in the base class
   with an additional animation, in which the words are blinking 
   in color, but not the spinner, during the animation. The standard
   "Get ready..." behavior is also included, but it is commented.

*****************************************************************
*/

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        //Mindfulness Program
        string option;
        int optionInt;

        int act1 = 0;
        int act2 = 0;
        int act3 = 0;

        //General menu
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options: \n");
            Console.WriteLine("1 - Start Breathing Activity");
            Console.WriteLine("2 - Start Reflecting Activity");
            Console.WriteLine("3 - Start Listing Activity");
            Console.WriteLine("4 - Quit");
            Console.Write("\nSelect a choice from the menu: ");
            option = Console.ReadLine();
            optionInt = int.Parse(option); 
            

            switch(optionInt)
            {
                case 1: //Console.WriteLine("Option: 1 - Breathing Activity\n");
                    act1++;
                    Console.Clear();                   
                    BreathingActivity breathingActivity = new BreathingActivity(null, null);
                    breathingActivity.RunBreathingActivity();
                break;

                case 2: //Console.WriteLine("Option: 2 - Reflecting Activity\n"); 
                    act2++;
                    Console.Clear();
                    ReflectingActivity reflectingActivity = new ReflectingActivity(null, null);
                    reflectingActivity.RunReflectingActivity();                
                break;

                case 3: //Console.WriteLine("Option: 3 - Listing Activity\n");
                    act3++;
                    Console.Clear();
                    ListingActivity listingActivity = new ListingActivity(null, null);
                    listingActivity.RunListingActivity();                    
                break;

                case 4:
                    Console.WriteLine("\nThanks for using the Mindfulness Program!");
                    Console.WriteLine($"\nIn this session you performed {act1} Breathing, {act2} Reflecting, and {act3} Listing activities.\n");
                break;
            }
        } while (optionInt != 4);
    }
}