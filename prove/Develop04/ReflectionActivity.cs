using System;
using System.Collections.Generic;

public class ReflectionActivity : Activity
{
    private List<string> _prompts = new List<string>
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something selfless."
    };

    private List<string> _questions = new List<string>
    {
        "Why was this experience meaningful to you?",
        "How did you feel afterward?",
        "What did you learn about yourself?",
        "What made this experience special?",
        "How can you apply it in the future?"
    };

    private Random _random = new Random();

    public ReflectionActivity()
        : base(
            "Reflection Activity",
            "This activity helps you reflect on times you showed strength.")
    { }

    public override void Run()
    {
        RecordActivity();

        StartActivity();

        Console.WriteLine();
        Console.WriteLine(
            _prompts[_random.Next(_prompts.Count)]
        );

        Loading.ShowSpinner(3);

        DateTime endTime =
            DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            string question =
                _questions[_random.Next(_questions.Count)];

            Console.WriteLine("\n" + question);

            Loading.ShowSpinner(5);
        }

        EndActivity();
    }
}