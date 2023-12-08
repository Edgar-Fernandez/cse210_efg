using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Foundation4 World!");
        //This program createS different Exercise Activities
        RunningActivity r1 = new RunningActivity("01 Jan 2023", 30, 10);
        CyclingActivity c1 = new CyclingActivity("14 Feb 2023", 60, 30);
        SwimmingActivity s1 = new SwimmingActivity("25 Dec 2023", 20, 20);

        List<Activity> activities = new List<Activity>();
        activities.Add(r1);
        activities.Add(c1);
        activities.Add(s1);

        Console.Clear();
        Console.WriteLine("\n\t>>>>>  LIST OF ACTIVITIES  <<<<<\n");

        int i = 1;
        foreach (Activity activity in activities)
        {
            Console.WriteLine($"Activity No.{i}: {activity.GetSummary()}");
            i++;
        }

        /******************************************CALIBRATIG DATA***********************************************
        To get an example of the classes calculating Distance, Speed, and Pace,
        uncomment the following 7 lines of code that use 30 minutes as Length (time):              */

        /*Console.WriteLine("\nACTIVITIES CREATED USING DATA FROM COURSE EXAMPLE: \n");
        RunningActivity r1t = new RunningActivity("03 Nov 2022", 30, 4.8); //4.8 km is equal to 96 laps (50m each lap)
        Console.WriteLine(r1t.GetSummary());
        CyclingActivity c1t = new CyclingActivity("03 Nov 2022", 30, 9.6); //9.6 km/h during 30 minutes gives a distance of 4.8km
        Console.WriteLine(c1t.GetSummary());
        SwimmingActivity s1t = new SwimmingActivity("03 Nov 2022", 30, 96); //96 laps is equal to 4.8km or 4800m
        Console.WriteLine(s1t.GetSummary());*/
    }
}