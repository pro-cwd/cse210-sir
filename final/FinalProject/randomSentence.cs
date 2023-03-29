using System;
using System.Linq;
using System.Collections.Generic;

public class RandomSentence
{
    public List<string> _word = new List<string>();
    public List<string> _sentence = new List<string>();
    
    public RandomSentence()
    {
        string file = "dict.txt";
        string[] lines = System.IO.File.ReadAllLines(file);
        // int count = 0;
        foreach (string line in lines)
        {
            char[] delimiterChars = {'|'};
            string[] part = line.Split(delimiterChars);
            _word.Add(part[0]);
            _sentence.Add(part[1]);
        }
    }

    public void _RandomSent()
    {
        bool myBool = true;
        int i = 0;
        int size = _sentence.Count();
        do
        {
            Random rand = new Random();
            int randIndex = rand.Next(_sentence.Count);
            // Console.WriteLine(_sentence[randIndex]);
            int stringLong = _word[randIndex].Length;
            string hiddenWord = new String('_', stringLong);
            string remplazado = _sentence[randIndex].Replace(_word[randIndex], hiddenWord);
            Console.Write("- {0} ", remplazado);
            _GetNum();
            Console.WriteLine();
            i++;
        } while (i <= size);
        // string randd = Console.ReadLine();
        // return randd;
    }
    public void _GetNum()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}