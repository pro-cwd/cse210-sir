using System;

public abstract class Dictionaries
{
    protected string _word;
    protected string _sentence;
    protected int _answer;
    public int _grades;

    public Dictionaries(string word, string sentence,  int answer)
    {
        _word = word;
        _sentence = sentence;
        _answer = answer;
    }

    public abstract void GetWords();
    
    public string WriteFile()
    {
        return $"{_word}|{_sentence}";
    }
   


}