using System;
using System.Collections.Generic;
using System.IO;

public class JournalManage
{
    private List<Journal> _entries = new List<Journal>();
    private string _filename = "journal.txt";

    public void AddEntry(Journal entry)
    {
        _entries.Add(entry);
    }

    public List<Journal> GetEntries()
    {
        return _entries;
    }

    public void Save()
    {
        using (StreamWriter outputFile = new StreamWriter(_filename))
        {
            foreach (Journal entry in _entries)
            {
                outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._entry}");
            }
        }
    }

    public void Load()
    {
        if (!File.Exists(_filename))
            return;

        _entries.Clear();

        string[] lines = File.ReadAllLines(_filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split('~');

            if (parts.Length == 3)
            {
                _entries.Add(new Journal
                {
                    _date = parts[0],
                    _prompt = parts[1],
                    _entry = parts[2]
                });
            }
        }
    }
}