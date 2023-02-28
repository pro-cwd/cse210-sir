using System;

public class Thought : Activities
{   
    private int _timeNum;
    private string _congrats;

    public Thought(string welcome, string message, string congrats) : base(welcome, message)
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

    public void CtrlThought()
    {
        GetReady();

        Console.WriteLine("For this activity seat down or keep a relaxed position. Next, look your thoughts pass, don't lose your observer position:\n");
        Console.Write("You may begin in:");
        GetNum(5);

        int i = 4;
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timeNum);
        do
        {
            Console.WriteLine("");
            Console.Write("look your thoughts pass...");
            GetNum(i++);
            Console.WriteLine("");
            Console.Write("don't lose your observer position...");
            GetNum(i++);
            Console.WriteLine("");
        } while (DateTime.Now < endTime);
    
        Console.WriteLine("Well done");
        GetSpinner();
        Console.Write("\n");
        ConGrats(_timeNum, _congrats);
        GetSpinner();

    }
}