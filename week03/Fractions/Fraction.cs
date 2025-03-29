public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int top)
    {
        _top = top;
        _bottom = 1;

    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Getters and Setters..................................
    // public int GetTop()
    // {
    //     return _top;
    // }

    // public void SetTop(int top)
    // {
    //     _top = top;
    // }

    // public int GetBottom()
    // {
    //     return _bottom;
    // }

    // public void SetBottom(int bottom)
    // {
    //     _bottom = bottom;
    // }

    public string GetFractionString()
    {
        return _top + "/" + _bottom;
        // Notice that this is not stored as a member variable.
        // Is is just a temporary, local variable that will be recomputed each time this is called.
        // string text = $"{_top}/{_bottom}";
        // return text;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

    // public void Display()
    // {
    //     Console.WriteLine(GetFractionString());
    //     Console.WriteLine(GetDecimalValue());
    // }
}
