using System;
public class RandomWords
{
    private string _word;
    public RandomWords()
    {
        string file = "dict.txt";
        string[] lines = System.IO.File.ReadAllLines(file);
        int count = 0;
        foreach (string line in lines)
        {
            char[] delimiterChars = {'|', '.', ' '};
            string[] part = line.Split(delimiterChars);
            _word = part[0];
            count++;
            Console.Write($"{count}. {_word} ");
        }
    }
}