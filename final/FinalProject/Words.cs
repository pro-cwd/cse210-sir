using System;
public class Words
{
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
}