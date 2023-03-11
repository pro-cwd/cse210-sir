using System;

public class EternalGoal : Goal
{
    // private int _amountGoal;
    public EternalGoal(string nameGoal, string descriptionGoal, int amountGoal) : base (nameGoal, descriptionGoal, amountGoal)
    {
        
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_amountGoal} points!");
        return _amountGoal;
    }
    public override bool IsComplete()
    {
        return false;
    }
    // public override void AddPoints()
    // {
        
    // }
    public override string WriteFile()
    {
        return $"EternalGoal|{_nameGoal}|{_descriptionGoal}|{_amountGoal}";
    }
    public override void ReturnGoal()
    {
        string completed = " ";
        Console.WriteLine($"[{completed}] {_nameGoal} ({_descriptionGoal})");
    }

}