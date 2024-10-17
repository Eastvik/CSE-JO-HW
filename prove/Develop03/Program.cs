public class Program
{
    static void Main(string[] args)
    {
        ScriptureLibrary library = new ScriptureLibrary();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            
            // Menu options
            library.DisplayScriptureMenu();
            
            Console.WriteLine("\nEnter the number of the scripture you want to select or type 'quit' to exit:");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
                break;

            int choice;
            if (int.TryParse(input, out choice))
            {
                Scripture selectedScripture;
                if (choice == library.GetScriptureCount() + 1)
                {
                    // Random scripture option
                    selectedScripture = library.GetRandomScripture();
                }
                else
                {
                    // Select scripture
                    selectedScripture = library.GetScriptureByIndex(choice - 1);
                }

                if (selectedScripture != null)
                {
                    // Loop to progressively hide words
                    while (!selectedScripture.AllWordsHidden())
                    {
                        selectedScripture.Display();
                        Console.WriteLine("\nPress Enter to hide some words or type 'quit' to exit:");
                        string userInput = Console.ReadLine();

                        if (userInput.ToLower() == "quit")
                            break;

                        selectedScripture.HideWords(3);
                    }

                    Console.WriteLine("All words are hidden. Returning to the menu...");
                }
            }
        }

        Console.WriteLine("Program has ended.");
    }
}
