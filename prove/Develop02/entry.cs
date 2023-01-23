using System.IO; 
using System;

public class Entry
{
        // public string _date = "";
        public string _quest;
        public string  _answer;

        public Entry()
        {
        }

        public void WriteText()
        {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();

        string journal = "myFile.txt";
        using (StreamWriter outputFile = new StreamWriter(journal))
        {
            // You can add text to the file with the WriteLine method
            outputFile.WriteLine($"{dateText} - Prompt: {_quest}");
            outputFile.WriteLine(_answer);
        }
        } 

        static void Question()
        {
            
        }
        
        
}

