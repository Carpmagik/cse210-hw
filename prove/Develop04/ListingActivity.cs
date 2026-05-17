using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Who are people you appreciate?",
        "What are your personal strengths?",
        "Who have you helped recently?",
        "What are positive things in your life?",
        "Who are your personal heroes?"
    };

    private Random _random = new Random();

    public ListingActivity()
        : base(
            "Listing Activity",
            "This activity helps you list positive things in your life.")
    { }

    public override void Run()
    {
        RecordActivity();
        
        StartActivity();

        string prompt =
            _prompts[_random.Next(_prompts.Count)];

        Console.WriteLine("\n" + prompt);

        Console.WriteLine("Get ready...");
        Loading.ShowCountdown(5);

        DateTime endTime =
            DateTime.Now.AddSeconds(GetDuration());

        int count = 0;

        Console.WriteLine("\nStart listing items:");

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            string input = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(input))
                count++;
        }

        Console.WriteLine($"\nYou listed {count} items.");

        EndActivity();
    }
}