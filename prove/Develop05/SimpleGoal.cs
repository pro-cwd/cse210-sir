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
    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
         return _completed;
    }
    public override void AddPoints()
    {
        
    }
    

}