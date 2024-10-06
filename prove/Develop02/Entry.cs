using System;

public class Entry
{
    public string Prompt { get; private set; }
    public string Response { get; private set; }
    public DateTime Date { get; private set; }

    public Entry(string prompt, string response)
    {
        Prompt = prompt;
        Response = response;
        Date = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Date.ToShortDateString()} - {Prompt}: {Response}";
    }
}
