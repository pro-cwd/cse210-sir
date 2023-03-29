using System;
using System.Linq;
using System.Collections.Generic;

public class PracticeMode 
{
    private string _f1; 
    private string _f2; 
    private List<string> _word = new List<string>();
    private List<string> _sentence = new List<string>();

    public PracticeMode(string file1, string file2)
    {
        _f1 = file1;
        _f2 = file2;

        string[] lines = System.IO.File.ReadAllLines(_f1);
        // int count = 0;
        foreach (string line in lines)
        {
            char[] delimiterChars = {'|'};
            string[] part = line.Split(delimiterChars);
            _word.Add(part[0]);
            _sentence.Add(part[1]);
        }
        
        string[] lines2 = System.IO.File.ReadAllLines(_f2);
        // int count = 0;
        foreach (string line in lines2)
        {
            char[] delimiterChars = {'|'};
            string[] part = line.Split(delimiterChars);
            _word.Add(part[0]);
            _sentence.Add(part[1]);
        }
    }
    public void _HideAll()
    {
        //runs the program until the user types quit or all words have been shown hidden
        bool indicator = true;
        
        while(indicator)
        {
            Console.Clear();
            myScripture.GetScripture();
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                indicator = false;
            }
            else
            {
                if(CompletelyHidden())
                {
                    indicator = false;
                }
                else
                {
                    HideWords();
                }
            }
        }
    }
    //function that checks which words are hidden, then randomly select half of the not hidden words and hides them
    public void HideWords()
    {
        int counter = 0;
        List<int> notHidden = new List<int>();
        foreach (Word w in _text)
        {
            if(!w.GetHidden())
            {
                notHidden.Add(counter);
            }
            counter++;
        }
        
        int notHiddenWords = notHidden.Count;
        Random rnd = new Random();
        List<int> randomNumber = new List<int>();
        
        for (int j = 0; j <= (notHiddenWords/2.0); j++)
        {
            randomNumber.Add(rnd.Next(notHiddenWords-1));
        }

        foreach (int r in randomNumber)
        {
            _text[notHidden[r]].Hide();
        }

    }

    //function that checks if all the words are hidden
    public bool CompletelyHidden()
    {
        int counter = 0;
        int hiddenWords = 0;
        foreach (Word w in _text)
        {
            counter++;
            if(w.GetHidden())
            {
                hiddenWords++;
            }
        }
        if(counter == hiddenWords)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}