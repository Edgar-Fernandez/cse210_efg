using System.Runtime.InteropServices;

public class Fraction
{
    //Atributes or variables
    private int _top;

    private int _bottom;
    

    // 3 Constructors
    public Fraction() // Constsuctor for no parameters
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholeNumber) //Constuctor for only one parameter as whole number
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom) //Consructor for 2 values. top and bottom
    {
        _top = top;
        _bottom = bottom;
    }

    //Setters and getters. To rite and read private variables or atributes

    public int GetTop() //Getter for top
    {
        return _top;
    }

    public void SetTop(int top) //Setter for top
    {
        _top = top;
    }

      public int GetBottom() //Getter for bottom
    {
        return _bottom;
    }

    public void SetBottom(int bottom) // Setter for bottom
    {
        _bottom = bottom;
    }

    // These are the methods

    public string GetFractionString()
    {
        string fractionString = _top.ToString() + "/" + _bottom.ToString();
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double fractionValue = (double)_top / (double)_bottom;
        return fractionValue;
    }

}