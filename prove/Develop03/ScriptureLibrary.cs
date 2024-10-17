public class ScriptureLibrary
{
    
    private List<Scripture> _scriptures;

    
    public ScriptureLibrary()
    {
        _scriptures = new List<Scripture>();
        LoadPredefinedScriptures();
    }

    // Can add more scriptures here.
    private void LoadPredefinedScriptures()
    {
        _scriptures.Add(new Scripture(
            "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.", 
            new Reference("John", 3, 16)));

        _scriptures.Add(new Scripture(
            "Trust in the Lord with all your heart and lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.", 
            new Reference("Proverbs", 3, 5, 6)));
        
        _scriptures.Add(new Scripture(
            "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them.", 
            new Reference("1st Nephi", 3, 7)));
        
        
    }

    //Do you read these?
    public Scripture GetScriptureByIndex(int index)
    {
        if (index >= 0 && index < _scriptures.Count)
        {
            return _scriptures[index];
        }
        return null;
    }

    //I hope you're having a good day.
    public Scripture GetRandomScripture()
    {
        Random random = new Random();
        return _scriptures[random.Next(_scriptures.Count)];
    }

    
    public void DisplayScriptureMenu()
    {
        for (int i = 0; i < _scriptures.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_scriptures[i].GetReference()}");
        }
        Console.WriteLine($"{_scriptures.Count + 1}. Random Scripture");
    }

    // Method to count scriptures
    public int GetScriptureCount()
    {
        return _scriptures.Count;
    }
}
