using System;

class Program
{
    static void Main(string[] args)
    {
        string[] choices = {"1. Start breathing activity", "2. Start reflecting activity", "3. Start listing actvity", "4. Quit"};
        bool myBool = true;
        do
        {
        Console.WriteLine("Menu Options:");
        foreach (string i in choices)
            {
                Console.WriteLine(i);
            }

        Console.Write("Select a choice from the menu: ");
        string num = Console.ReadLine();
        int numberElect = int.Parse(num);
        switch(numberElect)
            {
            case 1:
                Console.Clear();
                Console.WriteLine("Welcome to the Breathing Activity.\n");
                Console.WriteLine("This activity will help you relax by walking your through brathing in and out slowly. Clear your mind and focus on your breathing.\n");
                Console.Write("How long, in seconds, would you like for your session? ");
                string time = Console.ReadLine();
                int timeNum = int.Parse(time);

                Breathing breath = new Breathing(timeNum);
                // breath._timeNum = timeNum;
                breath.GetBreathing();
                

                break;
            case 2:
                
                break;
            case 3:
                
                break;
            case 4:
                myBool = false;
                break;
            default:
                Console.WriteLine("Pleace enter a number 1 to 4");
                break;
            }
        } while (myBool);
    }
}