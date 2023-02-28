using System;
public abstract  class Shape
{
    private string _colorMember;

    public Shape(string color)
    {
        _colorMember = color;
    }

    public string GetColor()
    {
        return _colorMember;
    }

    public void SetColor(string color)
    {
        _colorMember = color;
    }

   public abstract double GetArea();
}