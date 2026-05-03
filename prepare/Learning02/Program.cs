using System;

internal class Program
{
    private static void Main(string[] args)
    {

        Job job1 = new Job();
        job1._jobTitle = "Software Engineer";
        job1._company = "Microsoft";
        job1. _startYear = 2025;
        job1._endYear = 2026;

        Job job2 = new Job();
        job2._jobTitle = "Data Analyst";
        job2._company = "Google";
        job2. _startYear = 2025;
        job2._endYear = 2026;

        Resume myResume = new Resume();
        myResume._name = "Ryan Gosling";

        myResume._jobs.Add(job1);
        myResume._jobs.Add(job2);

        myResume.Display();
    }
}