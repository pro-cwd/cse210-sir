using System;
public class RandomSentence : Dictionaries
{
    public RandomSentence(string word, string sentence1, string sentence2, int answer): base(word, sentence1, sentence2, answer)
    {
        
    }

    public override void GetWords()
    {
       Console.WriteLine($"Word: {_word}\n  Sentence: {_sentence1}\n  Sentence: {_sentence2}\n  Points: {_answer}");
    }
}