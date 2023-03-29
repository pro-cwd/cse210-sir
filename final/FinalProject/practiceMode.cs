using System;
public class PracticeMode : Dictionaries 
{
    public PracticeMode(string word, string sentence, int answer): base(word, sentence, answer)
    {
        
    }

    public override void GetWords()
    {
        // string completed = " ";
        // if(IsComplete())
        // {
        //     completed = "x";
        // }

        Console.WriteLine($"Word: {_word}\n  Sentence: {_sentence}\n  Points: {_answer}");
    }
}