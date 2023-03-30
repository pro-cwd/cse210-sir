using System;
public class Words
{
    //stores each word and if its hidden or not.
    private string _singleWord;
    private string _singleSentence;
    private bool _isHidden;
    private string _word;
    private string _file;

    public Words(){}
    public Words(string file)
    {
        _file = file;
        string[] lines = System.IO.File.ReadAllLines(_file);
        int count = 0;
        foreach (string line in lines)
        {
            char[] delimiterChars = {'|'};
            string[] part = line.Split(delimiterChars);
            _word = part[0];
            count++;
            Console.Write($"{count}. {_word} ");
        }
    }
    public void Hide()
    {
        _isHidden = true;
    }
    public bool GetHidden()
    {
        if (_isHidden == true)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    public string GetWord(List<string> sts, List<string> wds)
    {
        if(_isHidden == false)
        {
            return _singleSentence;
        }
        else
        {   
            Random rand = new Random();
            int randIndex = rand.Next(sts.Count);
            int stringLenghth = wds[randIndex].Length;
            string hiddenWord = new String('_', stringLenghth);
            string remplazado = sts[randIndex].Replace(wds[randIndex], hiddenWord);
            return remplazado;
        }
    }
    

    //Set the word value. By default all words are not hidden when set.
    public void SetSentence(string sentence)
    {
        _singleSentence = sentence;
        _isHidden = false;
    }
    public void SetWord(string word)
    {
        _singleWord = word;
        _isHidden = false;
    }
}