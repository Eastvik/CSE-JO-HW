public class Word
{
    
    private string _word;
    private bool _isHidden;

    // Constructor
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    // Method to hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Method to check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    
    public override string ToString()
    {
        return _isHidden ? "_____" : _word;
    }
}
