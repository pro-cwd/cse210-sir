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
        // Console.Clear();
        int numberElect = int.Parse(num);
         
        switch(numberElect) 
            {
            case 1:
                Entry text = new Entry();
                text.Question();
                text._answer = Console.ReadLine();
                text.WriteText(); 

                break;
            case 2:
                Journal diss = new Journal();
                // diss.Display();
                break;
            // case 3:
            //     // code block
            //     break;
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