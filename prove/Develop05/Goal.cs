using System;

public abstract class Goal
{
    protected string _nameGoal;
    protected string _descriptionGoal;
    protected int _amountGoal;

    public Goal() {}

    public Goal(string nameGoal, string descriptionGoal, int amountGoal)
    {
        _nameGoal = nameGoal;
        _descriptionGoal = descriptionGoal;
        _amountGoal = amountGoal;
    }
    // public Type GetType();

    // public void MenuOptions(string[] choices)
    // {
       
    // }

    public string GetName()
    {
        return _nameGoal;
    }
    public string GetDescription()
    {
        return _descriptionGoal;
    }

    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract void AddPoints();
    
    public void ReturnGoal()
    {
        string completed = " ";
        if(IsComplete())
        {
            completed = "x";
        }

        Console.WriteLine($"[{completed}] {_nameGoal} ({_descriptionGoal})");
    }
}