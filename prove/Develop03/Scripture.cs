public class Scripture
{
    // Private fields for scripture text and reference
    private string _text;
    private Reference _reference;
    private List<Word> _words;

    // Constructor
    public Scripture(string text, Reference reference)
    {
        _text = text;
        _reference = reference;
        _words = new List<Word>();
        ParseTextToWords();
    }

    // Method to parse the scripture text into individual words
    private void ParseTextToWords()
    {
        string[] splitWords = _text.Split(' ');
        foreach (var word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    // Method to hide random words in the scripture
    public void HideWords(int count)
    {
        Random random = new Random();
        for (int i = 0; i < count; i++)
        {
            int index = random.Next(_words.Count);
            _words[index].Hide();
        }
    }

    //Check if all words are hidden
    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden());
    }

    //display scripture with hidden words
    public void Display()
    {
        Console.Clear();
        Console.WriteLine(_reference);
        foreach (var word in _words)
        {
            Console.Write(word + " ");
        }
        Console.WriteLine();
    }

    // Reference
    public string GetReference()
    {
        return _reference.ToString();
    }
}
