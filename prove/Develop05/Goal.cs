using System;

public  class Goal
{
    private string _nameGoal;
    private string _descriptionGoal;
    private string _amountGoal;

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