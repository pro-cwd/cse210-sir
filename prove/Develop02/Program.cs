using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!\n");
        Console.WriteLine("Welcome to the Journal program\n");
        
        string[] choices = {"1. White", "2. Display", "3. Load", "4. Save", "5. Quit"};
        bool myBool = true;
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
        Journal diss = new Journal();

        switch(numberElect) 
            {
            case 1:
                Random rand = new Random();
                string[] questions = {"What was the best part of my day?", "What are you grateful for today?", "What made you happy today?", "What have you learned today?", "Have I done any good today?"};
                int randIndex = rand.Next(questions.Length);
                Console.WriteLine(questions[randIndex]);
                string random = questions[randIndex];
                Console.Write(">");
                
                Entry text = new Entry();
                text._quest = random;
                text._answer = Console.ReadLine();
                // text.WriteText();

                // Journal diss = new Journal();
                // diss._entries.add(text);

                Console.WriteLine(" ");
                break;
            case 2:
                // Journal diss = new Journal();
                diss.Display();

                Console.WriteLine(" ");
                break;
            case 3:
                Console.WriteLine("What is the filename");
                string file = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(file);

                foreach (string line in lines)
                {
                    char[] delimiterChars = {',', '-', '?'};
                    string[] parts = line.Split(delimiterChars);



                }
                Console.WriteLine(" ");
                break;
            case 4:
                Entry readEntry = new Entry();
                Console.WriteLine("Whats is your filename?");
                string jnal = Console.ReadLine();
                readEntry._file = jnal;
                Console.WriteLine(" ");
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