using System;

public abstract class Goal
{
    private string _nameGoal = "";
    private string _descriptionGoal = "";
    private int _amountGoal;
    public Goal()
    {

    }

    public void MenuOptions(string[] choices)
    {
        foreach (string i in choices)
            {
                Console.WriteLine(i);
            }
    }

    // public string GetName()
    // {
    //     return _colorMember;
    // }

    public abstract int ShowAmount();

}