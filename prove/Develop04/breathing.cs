
public class Breathing : Activities
{
    private int _timeNum;

    public Breathing(string welcome, string message): base(welcome, message)
    {
        
    }
    public int GetTime()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string tm = Console.ReadLine();
        _timeNum = int.Parse(tm);
        return _timeNum;
    }
    int spinn = GetTime();
    double spinn10 = (spinn / 100)*10;
    double spinn15 = (spinn / 100)*20;

    public void GetBreathing()
    {   
        Console.Clear();
        Console.WriteLine("Get ready...");
        GetSpinner();
        Console.WriteLine("");

        if
        for (int i = 5 )        

    }

}