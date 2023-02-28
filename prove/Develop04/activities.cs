using System;

public class Activities
{
    private string _welcome;
    private string _message;

    public Activities(string welcome, string message)
    {
        _welcome = welcome;
        _message = message;
        
        
    }
    public string GetWelcome()
    {
        return _welcome;
    }

    public string GetMessage()
    {
        return _message;
    }

    List<string> animationStrings = new List<string>();

    public void GetSpinner()
    {
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        animationStrings.Add("/");
        animationStrings.Add("-");
        animationStrings.Add("\\");
        animationStrings.Add("|");
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(9);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animationStrings[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            i++;

            if (i >= animationStrings.Count)
            {
                i = 0;
            }
        }
    }

     public void GetNum(int num)
    {
        for (int i = num; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void ConGrats(int time, string activity)
    {
        Console.Write($"You have completed another {time} seconds of the {activity}");
        Console.WriteLine("");
    }
    public void GetReady()
    {
        Console.Clear();
        Console.WriteLine("Get ready...");
        GetSpinner();
        Console.WriteLine("");
    }
     public void WellDone()
    {
        // Console.Clear();
        Console.WriteLine("Well Done!!");
        GetSpinner();
        Console.WriteLine("");
    }

}