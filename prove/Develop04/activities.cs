using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Text;
// using System.Threading.Tasks;

public class Activities
{
    private string _welcome;
    private string _message;
    // public List<string> _ListPrompts = new List<string>();

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

    // public void ShowPrompt()
    //      {
    //         Random rand = new Random();
    //        string[] list = {"Think of a time when you stood up for someone else.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless."};
    //         int randIndex = rand.Next(list.Length);
    //         Console.WriteLine($"--- {list[randIndex]} ---");
    // //         string randd = _ListPrompts[randIndex];
    // //         return randd;
    //      }
    //  public void Display()
    //     {
    //             foreach ( string entry in _ListPrompts)
    //             {
    //                     Console.WriteLine($"--- {entry} ---");

    //             }

    //     }
    


}