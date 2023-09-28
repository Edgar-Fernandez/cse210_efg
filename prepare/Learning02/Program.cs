using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning02 World!");
        Job job1 = new Job();
        job1._company = "Microsoft";
        job1._jobTitle = "Software Engineeer";
        job1._startYear = 2019;
        job1._endYear = 2022;

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2022;
        job2._endYear = 2023;

        //Console.WriteLine(job1._company);
        //Console.WriteLine(job2._company);

        //job1.PrintJobDetails();
        //job2.PrintJobDetails();

        Resume myResume = new Resume();
        //myResume._jobs[0] = job1; // These don't work.
        //myResume._jobs[1] = job2;

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        //Console.WriteLine(myResume._jobs[0]._jobTitle);
        //Console.WriteLine(myResume._jobs[1]._jobTitle);

        myResume.DisplayJobList();

    }
}