using System;
public class HardTest : Dictionaries
{
    public HardTest(string word, string sentence1, string sentence2, int answer): base(word, sentence1, sentence2, answer)
    {
        
    }

    public override void GetWords()
    {
        // string completed = " ";
        // if(IsComplete())
        // {
        //     completed = "x";
        // }

        // Console.WriteLine($"[{completed}] {_nameGoal} ({_descriptionGoal})");
    }
}