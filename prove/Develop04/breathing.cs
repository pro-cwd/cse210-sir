
public class Breathing : Activities
{
    private int _timeNum;
    private string _congrats;

    public Breathing(string welcome, string message, string congrats): base(welcome, message)
    {
        _congrats = congrats;
    }
    public int GetTime()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        string tm = Console.ReadLine();
        _timeNum = int.Parse(tm);
        return _timeNum;
    }

    public void GetBreathing()
    {   
        GetReady();
        int i = 2;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timeNum);
        do
        {
            Console.WriteLine("");
            Console.Write("Breathe in...");
            GetNum(i++);
            Console.WriteLine("");
            Console.Write("Breathe out...");
            GetNum(i+1);
            Console.WriteLine("");
        } while (DateTime.Now < endTime);
    
        Console.WriteLine("Well done");
        GetSpinner();
        Console.Write("\n");
        ConGrats(_timeNum, _congrats);
        GetSpinner();

    }

}