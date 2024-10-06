using System;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();
        PromptGenerator promptGen = new PromptGenerator();

        
        journal.ReadFromFile();

        bool running = true;
        while (running)
        {
            Console.Write("Please input the number: (1)'new journal entry', (2)'read entries', or (0)'save & exit':> ");
            string answer = Console.ReadLine().ToLower();

            if (answer == "1")
            {
                string prompt = promptGen.GetRandomPrompt();
                Console.WriteLine(prompt);

                string response = Console.ReadLine();
                Entry entry = new Entry(prompt, response);
                journal.AddEntry(entry);
                journal.SaveToFile();
            }
            else if (answer == "2")
            {
                
                journal.ReadFromFile();
            }
            else if (answer == "0")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option, please try again.");
            }
        }

        journal.DisplayEntries();
    }
}