using System;
public class PracticeMode : Dictionary
{
    public PracticeMode(string word, string sentence1, string sentence2, int answer): base(word, sentence1, sentence2, answer)
    {
        
    }

    public override void GetWords()
    {
        // string completed = " ";
        // if(IsComplete())
        // {
        //     completed = "x";
        // }

        Console.WriteLine($"Word: {_word}\n  Sentence: {_sentence1}\n  Sentence: {_sentence2}\n  Points: {_answer}");
    }
}