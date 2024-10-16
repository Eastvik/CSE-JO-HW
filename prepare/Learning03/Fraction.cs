using System

public class Fraction
{
    private int _numer;
    private int _denom;

    public Fraction()

    {
        _numer = 1;
        _denom = 1;
    }
    public Fraction(int wholenum)
    {
        _numer = wholenum;
        _denom = 1;
    }
    
    public Fraction(int top, int bottom)
    {
        _numer = top;
        _denom = bottom;
    }

    public string GetFracString()
    {
        string text = $"{_numer}/{_denom}";
        return text;
    }

    public double GetDecValue()
    {
        return (double)_numer / (double)_denom;
    }
}
