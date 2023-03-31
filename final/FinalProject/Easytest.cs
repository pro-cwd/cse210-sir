using System;
public class EasyTest : Dictionaries
{
    public EasyTest(string word, string sentence, int answer): base(word, sentence, answer)
    {
        
    }
    public override void GetWords()
    {
        Console.WriteLine($"Word: {_word} | Sentence: {_sentence} |Points: {_answer}");
        
    }
}