using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!\n");
        Console.WriteLine("Welcome to the Journal program\n");

        string[] choices = {"1. White", "2. Display", "3. Load", "4. Save", "5. Quit"};
        bool myBool = true;
        Journal myJournal = new Journal();
        PromptGenerator myPrompt = new PromptGenerator();
        do
        {
        Console.WriteLine("Pleace select one of the following choices:");
        foreach (string i in choices)
            {
                Console.WriteLine(i);
            }

        Console.Write("What would you like to do? ");
        string num = Console.ReadLine();
        int numberElect = int.Parse(num);

        switch(numberElect)
            {
            case 1:
                 DateTime theCurrentTime = DateTime.Now;
                string dateText = theCurrentTime.ToShortDateString();
                string random = myPrompt.ShowPrompt();
                Console.Write("> ");

                Entry text = new Entry();
                text._dateText = dateText;
                text._quest = random;
                text._answer = Console.ReadLine();
                myJournal._entries.Add(text);
                Console.WriteLine(" ");
                break;
            case 2:
                myJournal.Display();
                // Console.WriteLine(" ");
                break;
            case 3:
                Console.WriteLine("What is the filename");
                string file = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(file);

                foreach (string line in lines)
                    {
                        char[] delimiterChars = {':','-','?'};
                        string[] parts = line.Split(delimiterChars);

                        Entry readText = new Entry();
                        readText._dateText = parts[0].Trim();
                        readText._quest = parts[1].Trim() + "?";
                        readText._answer = parts[2].Trim();
                        myJournal._entries.Add(readText);
                    }
                Console.WriteLine(" ");
                break;
            case 4:
                // Entry readEntry = new Entry();
                Console.WriteLine("Whats is your filename?");
                string journal = Console.ReadLine();
                using (StreamWriter outputFile = new StreamWriter(journal))
                    {
                        foreach ( Entry entry in myJournal._entries)
                        {
                            outputFile.WriteLine($"{entry._dateText} - {entry._quest} {entry._answer}");
                        }
                    }

                // readEntry._file = jnal;
                // Console.WriteLine(" ");
                break;
            case 5:
                myBool = false;
                break;
            default:
                Console.WriteLine("Pleace enter a number 1 to 5");
                break;
            }
        } while (myBool);
    }
}