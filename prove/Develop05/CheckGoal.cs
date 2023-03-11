using System;

public class CheckGoal : Goal
{
    private int _bonus;
    private int _bonusOne;
     //stores number of times the goal was completed
    private int _accomplished;

    public CheckGoal(){}

    public CheckGoal(string nameGoal, string descriptionGoal, int amountGoal, int bonusOne, int bonus) : base (nameGoal, descriptionGoal, amountGoal)
    {
        _bonus = bonus;
        _bonusOne = bonusOne;
        _accomplished = 0;
    }
    public int _GetBonus()
    {
        return _bonus;
    }
    public int _GetBonus1()
    {
        return _bonusOne;
    }
    public override void RecordEvent()
    {

    }
   public override bool IsComplete()
    {
        if(_accomplished == _bonusOne)
        {
            return true;
        }
        else
        {
            return false;
        }
        
    }
    public override void AddPoints()
    {
        
    }
   


}