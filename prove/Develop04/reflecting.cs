using System;

public class Reflecting : Activities
{
    private int _timeNum;
    private string _congrats;

    public Reflecting(string welcome, string message, string congrats) : base(welcome, message)
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
    public void Thinking()
    {   
        GetReady();
        
        string a = ShowPrompt();
        Console.WriteLine("Consider the following prompt:\n");
        Console.WriteLine($"--- {a} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue.");
        string input = Console.ReadLine();
        Console.Write("\nNow ponder on each of the following questions as they related to the experience. You may bigin in:");
        GetNum(5);
        
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timeNum);

        Console.Clear();
        int i = 0;

        while (DateTime.Now < endTime)
        {   
            Console.Write("> ");
            string qs = GetQuestions();
            Console.WriteLine(qs);
            GetSpinner();
            i++;
            
        }
        WellDone();
        ConGrats(_timeNum, _congrats);
        GetSpinner();
    }

    public string GetQuestions()
        {
            Random rand = new Random();
            string[] list = {"Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?"};
            int randIndex = rand.Next(list.Length);
            // Console.WriteLine(list[randIndex]);
            string randd = list[randIndex];
            return randd;
         }

    public string ShowPrompt()
         {
            Random rand = new Random();
            string[] list = {"Think of a time when you stood up for someone else.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless.","Think of a time when you did something really difficult."};
            int randIndex = rand.Next(list.Length);
            // Console.WriteLine(list[randIndex]);
            string randd = list[randIndex];
            return randd;
         }
}