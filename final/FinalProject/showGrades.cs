using System;
public class ShowGrades : Dictionaries
{
    private int _pointPlus;

    public ShowGrades(string word, string sentence, int answer): base(word, sentence, answer)
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

    // public override bool IsComplete()
    // {
    //     if(_accomplished == _bonusOne)
    //     {
    //         return true;
    //     }
    //     else
    //     {
    //         return false;
    //     }
        
    // }
}