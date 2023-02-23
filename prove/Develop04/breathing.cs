
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
    int time10 = (_timeNum / 100)*10;
    int time15 = (_timeNum / 100)*20;

    public void GetTime()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void GetBreathing()
    {   
        Console.Clear();
        Console.WriteLine("Get ready...");
        GetSpinner();
        Console.WriteLine("");
        Console.WriteLine(_timeNum);

        Console.WriteLine($"Breathe in... {GetTime()}");

    }

}