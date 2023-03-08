using System;

public class SimpleGoal : Goal
{
    private string _nameGoal = "";
    private string _descriptionGoal = "";
    private int _amountGoal;

    public SimpleGoal(string nameGoal, string descriptionGoal, int amountGoal)
    {
        _nameGoal = nameGoal;
        _descriptionGoal = descriptionGoal;
        _amountGoal = amountGoal;
    }
    // public override int ShowAmount()
    // {
    //     return _amountGoal;
    // }

}