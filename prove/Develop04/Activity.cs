using System;

public abstract class Activity
{
    private string _name;
    private string _description;
    private int _duration;


    private static int _timesPerformed = 0;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void RecordActivity()
    {
        _timesPerformed++;
    }

    public void StartActivity()
    {
        Console.Clear();

        Console.WriteLine($"--- {_name} ---");
        Console.WriteLine(_description);
        Console.WriteLine();

        Console.Write("Enter duration in seconds: ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine("\nPrepare to begin...");
        Loading.ShowSpinner(3);
    }

    public void EndActivity()
    {
        Console.WriteLine("\nGood job!");
        Loading.ShowSpinner(2);

        Console.WriteLine($"You completed {_name} for {_duration} seconds.");

  
        Console.WriteLine(
            $"This activity has been performed {_timesPerformed} time(s) total."
        );

        Loading.ShowSpinner(3);
    }

    public abstract void Run();
}