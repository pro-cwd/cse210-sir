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
         
        switch(numberElect) 
            {
            case 1:
                Random rand = new Random();
                string[] questions = {"What was the best part of my day?", "What are you grateful for today?", "What made you happy today?", "What have you learned today?", "Have I done any good today?"};
                int randIndex = rand.Next(questions.Length);
                Console.WriteLine(questions[randIndex]);
                string random = questions[randIndex];
                
                Entry text = new Entry();
                text._quest = random;
                text._answer = Console.ReadLine();
                text.WriteText(); 
                break;
            case 2:
                Journal diss = new Journal();
                diss.Display();
                break;
            case 3:
                //code block
                break;
            // case 4:
            //     // code block
            //     break;
            // case 5:
            //     // code bloc
            //     k
            //     break;
            default:
                Console.WriteLine("Pleace enter a number 1 to 5");
                break;
            }
        } while (myBool);
    }
    

}