using System;
using System.Collections.Generic;
using System.IO;

public class Journal
{
    private List<Entry> entries;
    private const string fileName = "journal.txt";

    public Journal()
    {
        entries = new List<Entry>();
    }

    
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }

    
    public void DisplayEntries()
    {
        foreach (Entry entry in entries)
        {
            Console.WriteLine(entry.ToString());
        }
    }

    
    public void SaveToFile()
    {
        using (StreamWriter writer = new StreamWriter(fileName, true)) 
        {
            foreach (Entry entry in entries)
            {
                writer.WriteLine(entry.ToString());
            }
        }
        Console.WriteLine("Journal entries saved to 'journal.txt'.");
    }

    
    public void ReadFromFile()
    {
        if (File.Exists(fileName))
        {
            Console.WriteLine($"Displaying entries from {fileName}:");
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
        else
        {
            Console.WriteLine($"File '{fileName}' not found.");
        }
    }
}
