using System.IO; 
using System;

public class Entry
{
        // public string _date = "";
        
        public string  _answer = "";

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
            outputFile.WriteLine($"{dateText} - Prompt: {variable2}");
            outputFile.WriteLine(_answer);
        }

        }
        
        public void Question()
        {
            Random rand = new Random();
            string[] questions = {"What was the best part of my day?", "What are you grateful for today?", "What made you happy today?", "What have you learned today?", "Have I done any good today?"};
            int randIndex = rand.Next(questions.Length);
    
            Console.WriteLine(questions[randIndex]);
            
        }
}

