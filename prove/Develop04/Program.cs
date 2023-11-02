using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");
        //Mindfulness Program
        string option;
        int optionInt;
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
                case 1: //Write new entry
                    Console.Clear();
                    BreathingActivity breathingActivity = new BreathingActivity("", "", 0);
                    breathingActivity.RunBreathingActivity();

                break;

                case 2:
                    Console.Clear();
                    //Console.WriteLine("Option: 2 - Reflecting Activity\n");
                    ReflectingActivity reflectingActivity = new ReflectingActivity("", "", 0);
                    reflectingActivity.RunReflectingActivity();               

                break;

                case 3:
                    Console.Clear();
                    Console.WriteLine("Option: 3 - Listing Activity\n");
                    Console.ReadLine();


                break;

                case 4:
                    Console.WriteLine("\nThanks for using the Mindfulness Program!\n");

                break;
            }
        } while (optionInt != 4);
    }
}