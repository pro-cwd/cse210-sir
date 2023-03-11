using System;
public class SimpleGoal: Goal
{
    private bool _completed;

    public SimpleGoal(string name, string description, int amount) : base (name, description, amount)
    {
       _completed = false;
    }
    public SimpleGoal(string name, string description, int amount, bool completed) : base (name, description, amount)
    {
        _completed = completed;   
    }
    public override int RecordEvent()
    {
        _completed = true;
        Console.WriteLine($"Congratulations! You have earned {_amountGoal} points!");
        return _amountGoal;
    }
    public override bool IsComplete()
    {
         return _completed;
    }
    // public override void AddPoints()
    // {
        
    // }
    public override string WriteFile()
    {
        return $"SimpleGoal|{_nameGoal}|{_descriptionGoal}|{_amountGoal}|{_completed}";
    }

    public override void ReturnGoal()
    {
        string completed = " ";
        if(IsComplete())
        {
            completed = "x";
        }

        Console.WriteLine($"[{completed}] {_nameGoal} ({_descriptionGoal})");
    }
}