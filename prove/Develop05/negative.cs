public class Negative : Goal
{
    public Negative (string name, string description, int amount) : base (name, description, amount)
    {
           
    }

    public override int RecordEvent()
    {
        Console.WriteLine($"Sorry. You have lost {_amountGoal} points!");
        int negPoints = _amountGoal * -1;
        return negPoints;
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string WriteFile()
    {
        return $"Negative|{_nameGoal}|{_descriptionGoal}|{_amountGoal}";
    }

    public override void ReturnGoal()
    {
        string completed = " ";
        Console.WriteLine($"[{completed}] {_nameGoal} ({_descriptionGoal}) -- Bad Habit");
    }
}