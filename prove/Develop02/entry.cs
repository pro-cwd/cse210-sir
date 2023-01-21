using System.IO; 
using System;

public class Entry
{
        public string _answer = "";
        public string _date = "";
        public string _quest = "";
        
        public Entry()
        {
        string journal = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(journal))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"{_date} - Prompt: {_quest}");
            outputFile.WriteLine(_answer);
        }
        }

    
    
}

