using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> activities = new List<Activity>();

        Running a1 =new Running("6/2/2026", "Running", 60, 4.0);
        activities.Add(a1);

        Cycling a2 = new Cycling("6/3/2026", "Cycling", 45, 15.0);
        activities.Add(a2);

        Swimming a3 = new Swimming("6/4/2026", "Swimming", 30, 20);
        activities.Add(a3);

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}