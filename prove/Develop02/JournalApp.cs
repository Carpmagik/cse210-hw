using System;

public class JournalApp
{
    private JournalManage _manager = new JournalManage();

    public JournalApp(JournalManage manage)
    {
        _manager = manage;
    }

    private Random _rand = new Random();

    public void Run()
    {
        bool _running = true;

        while (_running)
        {
            Console.WriteLine("\n1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Save");
            Console.WriteLine("4. Load");
            Console.WriteLine("5. Quit");

            string _choice = Console.ReadLine();

            if (_choice == "1")
                WriteEntry();

            else if (_choice == "2")
                Display();

            else if (_choice == "3")
                _manager.Save();

            else if (_choice == "4")
                _manager.Load();

            else if (_choice == "5")
                _running = false;
        }
    }

    private void WriteEntry()
    {
        string[] _prompts =
        {
            "What did you eat today?",
            "What was the best part of your day?",
            "What are you grateful for?",
            "What did you learn today?",
            "Did you have any regrets?",
            "What made you happy today?",
            "What made you sad today?",
        };

        string _prompt = _prompts[_rand.Next(_prompts.Length)];

        Console.WriteLine(_prompt);
        string _entry = Console.ReadLine();

        _manager.AddEntry(new Journal
        {
            _prompt = _prompt,
            _entry = _entry,
            _date = DateTime.Now.ToShortDateString()
        });
    }

    private void Display()
    {
        foreach (Journal entry in _manager.GetEntries())
        {
            Console.WriteLine(entry._date);
            Console.WriteLine(entry._prompt);
            Console.WriteLine(entry._entry);
            Console.WriteLine();
        }
    }
}