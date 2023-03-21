using System;

public abstract class Dictionary
{
    protected string _word;
    protected string _sentence1;
    protected string _sentence2;
    protected int _answer;
    public int _grades;

    public Dictionary(string word, string sentence1, string sentence2, int answer)
    {
        _word = word;
        _sentence1 = sentence1;
        _sentence2 = sentence2;
        _answer = answer;
    }


}