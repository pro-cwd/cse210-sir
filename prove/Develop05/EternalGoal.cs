using System;

public class EternalGoal : Goal
{
    // private int _amountGoal;
    public EternalGoal(string nameGoal, string descriptionGoal, int amountGoal) : base (nameGoal, descriptionGoal, amountGoal)
    {
        
    }

    public override void RecordEvent()
    {

    }
    public override bool IsComplete()
    {
        return false;
    }
    public override void AddPoints()
    {
        
    }

}