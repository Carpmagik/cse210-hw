using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base(
            "Breathing Activity",
            "This activity helps you relax by guiding you through slow breathing.")
    { }

    public override void Run()
    {   
        RecordActivity();
        
        StartActivity();

        DateTime endTime =
            DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            Console.WriteLine("\nBreathe in...");
            Loading.ShowCountdown(4);

            Console.WriteLine("Breathe out...");
            Loading.ShowCountdown(4);
        }

        EndActivity();
    }
}