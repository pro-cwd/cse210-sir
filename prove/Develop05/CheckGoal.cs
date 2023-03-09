using System;

public class CheckGoal : Goal
{
    private int _bonus;

    public CheckGoal(string nameGoal, string descriptionGoal, string amountGoal, int bonus) : base (nameGoal, descriptionGoal, amountGoal)
    {
        _bonus = bonus;
    }

   


}