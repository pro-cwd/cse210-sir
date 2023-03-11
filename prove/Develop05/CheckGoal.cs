using System;

public class CheckGoal : Goal
{
    private int _bonus;
    private int _bonusOne;
     //stores number of times the goal was completed
    private int _accomplished;

    public CheckGoal(){}

    public CheckGoal(string nameGoal, string descriptionGoal, int amount, int bonusOne, int bonus) : base (nameGoal, descriptionGoal, amount)
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
    public override int RecordEvent()
    {
        _accomplished++;
        if(_accomplished == _bonusOne)
        {
            Console.WriteLine($"Congratulations! You have earned {_amountGoal + _bonus} points!");
            return _amountGoal + _bonus;
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_amountGoal} points!");
            return _amountGoal;
        }
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
    // public override void AddPoints()
    // {
        
    // }
    public override string WriteFile()
    {
        return $"CheckGoal|{_nameGoal}|{_descriptionGoal}|{_amountGoal}|{_bonusOne}|{_bonus}|{_accomplished}";
    }
    public override void ReturnGoal()
    {
        string completed = " ";
        if(IsComplete())
        {
            completed = "x";
        }

        Console.WriteLine($"[{completed}] {_nameGoal} ({_descriptionGoal}) -- Currently completed: {_accomplished}/{_bonusOne}");
    }
   


}