public abstract class Shape
{
    private string _color;

    // Constructor
    public Shape(string color)
    {
        _color = color;
    }

    // Getter and Setter for Color
    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    // Virtual method for area calculation
    public abstract double GetArea();
}
