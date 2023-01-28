using System;
using System.IO;

public class Entry
{
        // public string _date = "";
        public string _quest = "";
        public string  _answer = "";
        public string _dateText ="";
        public string _file;

        public void DisplayEntry()
        {
            Console.WriteLine($"Date: {_dateText} - Prompt: {_quest}");
            Console.WriteLine($"{_answer}");
        }

        // public void WriteText()
        // {
        // string journal = _file;
        // using (StreamWriter outputFile = new StreamWriter(journal))
        //     {
        //         // You can add text to the file with the WriteLine method
        //         outputFile.WriteLine($"{_dateText} - Prompt: {_quest}");
        //         outputFile.WriteLine($"{_answer}\n");
        //     }
        // } 

        
        
}

