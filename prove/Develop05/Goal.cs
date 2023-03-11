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
 
    public string GetName()
    {
        return _nameGoal;
    }
    public string GetDescription()
    {
        return _descriptionGoal;
    }

    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract void ReturnGoal();
    
    public void ReturnGoalName()
    {
       Console.WriteLine($"{_nameGoal}");
    }
    public abstract string WriteFile();
}