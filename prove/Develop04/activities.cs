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
        // foreach (string s in animationStrings)
        // {
        //     Console.Write(s);
        //     Thread.Sleep(1000);
        //     Console.Write("\b \b");
        // }
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(10);

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
   
    

}