using System;

public class Listing : Activities
{
    private int _timeNum;
    private string _congrats;
    private string _answer;
    public List<string> _listAns = new List<string>();
 
    public Listing(string welcome, string message, string congrats) : base(welcome, message)
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
    public void Listact()
    {
        GetReady();
         
        Console.WriteLine("List as many responses you can to the folloing  prompt:\n");
        string a = ShowPrompt();
         Console.WriteLine($"--- {a} ---\n");
         Console.Write("You may begin in:");
        GetNum(5);
        Console.WriteLine(" ");
        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_timeNum);

        int i = 0;

        while (DateTime.Now < endTime)
        {   
            Console.Write("> ");
            _answer = Console.ReadLine();
            _listAns.Add(_answer);
            i++;
        }
        Console.WriteLine($"You listed {i} items!\n");
        WellDone();
        ConGrats(_timeNum, _congrats);
        GetSpinner();

    }
    public string ShowPrompt()
         {
            Random rand = new Random();
            string[] list = {"Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?","When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?"};
            int randIndex = rand.Next(list.Length);
            // Console.WriteLine(list[randIndex]);
            string randd = list[randIndex];
            return randd;
         }

}