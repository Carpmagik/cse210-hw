using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    public string _prompt;
    public string _entry;
    public string _date;
}

public class JournalApp
{
    private static Random rand = new Random();

    public void Run()
    {
        List<Journal> journalEntries = new List<Journal>();
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nSelect an option:");
            Console.WriteLine("1. Write a new entry");
            Console.WriteLine("2. Display journal");
            Console.WriteLine("3. Save journal");
            Console.WriteLine("4. Load journal");
            Console.WriteLine("5. Quit");
            Console.Write("Select an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
                WriteEntry(journalEntries);
            else if (choice == "2")
                DisplayJournal(journalEntries);
            else if (choice == "3")
                SaveToFile(journalEntries);
            else if (choice == "4")
                LoadJournal(journalEntries);
            else if (choice == "5")
                running = false;
        }
    }

    private static void WriteEntry(List<Journal> entries)
    {
        string[] prompts =
        {
            "What did you eat today?",
            "What was the best part of your day?",
            "What did you hate about today?",
            "What was the strongest emotion you felt today?",
            "Did you have any regrets?",
            "What are you grateful for today?"
        };

        string prompt = prompts[rand.Next(prompts.Length)];

        Console.WriteLine("\nPrompt: " + prompt);
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        entries.Add(new Journal
        {
            _prompt = prompt,
            _entry = response,
            _date = DateTime.Now.ToShortDateString()
        });
    }

    private static void DisplayJournal(List<Journal> entries)
    {
        Console.WriteLine("\n=== Journal Entries ===");

        foreach (Journal entry in entries)
        {
            Console.WriteLine($"Date: {entry._date}");
            Console.WriteLine($"Prompt: {entry._prompt}");
            Console.WriteLine($"Entry: {entry._entry}");
            Console.WriteLine();
        }
    }

    private static void SaveToFile(List<Journal> entries)
    {
        Console.WriteLine("Saving to file...");
        string filename = "journal.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Journal entry in entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._entry}");
            }
        }
    }

    private static void LoadJournal(List<Journal> entries)
    {
        string filename = "journal.txt";
        
        string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('~');

            {
                entries.Add(new Journal
                {
                    _date = parts[0],
                    _prompt = parts[1],
                    _entry = parts[2]
                });
            }
        }
    }
}