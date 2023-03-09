using System;

public  class Goal
{
    public string _nameGoal;
    public string _descriptionGoal;
    public string _amountGoal;

    public Goal() {}

    public Goal(string nameGoal, string descriptionGoal, string amountGoal)
    {
        _nameGoal = nameGoal;
        _descriptionGoal = descriptionGoal;
        _amountGoal = amountGoal;
    }

    public void MenuOptions(string[] choices)
    {
        foreach (string i in choices)
            {
                Console.WriteLine(i);
            }
    }

    public string GetName()
    {
        return _nameGoal;
    }
    public string GetDescription()
    {
        return _descriptionGoal;
    }
}