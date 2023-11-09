public class Shape
{
    protected string _color;

    public Shape (string color)
    {
        _color = color;
    }

    public void SetColor (string color) //setter
    {
        _color = color;
        return;
    }

    public string GetColor () //getter
    {
        return _color;
    }

    public virtual double GetArea()
    {
        return 0;
    }

}