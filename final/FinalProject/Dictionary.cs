using System;

public abstract class Dictionaries
{
    protected string _word;
    protected string _sentence1;
    protected string _sentence2;
    protected int _answer;
    public int _grades;

    public Dictionaries(string word, string sentence1, string sentence2, int answer)
    {
        _word = word;
        _sentence1 = sentence1;
        _sentence2 = sentence2;
        _answer = answer;
    }

    public abstract void GetWords();
    // public abstract void GetWComplete();
    // public abstract void GetRandSen();
    // public abstract void GetRandWord();

    // public int ShowGrades()
    // {

    // }
    public string WriteFile()
    {
        return $"{_word}|{_sentence1}|{_sentence2}";
    }


}