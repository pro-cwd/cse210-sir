using System;

class Program
{
    static void Main(string[] args)
    {
        string[] choices = {"1. Start breathing activity", "2. Start reflecting activity", "3. Start listing actvity", "4. Start thought activity", "5. Quit"};
        bool myBool = true;
        do
        {
            Console.Clear();
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
                    Breathing welcome = new Breathing("Welcome to the Breathing Activity.\n", "This activity will help you relax by walking your through brathing in and out slowly. Clear your mind and focus on your breathing.\n", "Breathing Activity");
                    Console.WriteLine(welcome.GetWelcome());
                    Console.WriteLine(welcome.GetMessage());
                    welcome.GetTime();
                    welcome.GetBreathing();
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.Clear();
                    Reflecting welcome2 = new Reflecting("Welcome to the Reflection Activity", "his activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflecting Activity\n");
                    Console.WriteLine(welcome2.GetWelcome());
                    Console.WriteLine(welcome2.GetMessage());
                    welcome2.GetTime();
                    welcome2.Thinking();
                    break;
                case 3:
                    Console.Clear();
                    Listing welcome3 = new Listing("Welcome to the Listing Activity\n", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.\n", "Listing Activity.\n");
                    Console.WriteLine(welcome3.GetWelcome());
                    Console.WriteLine(welcome3.GetMessage());
                    welcome3.GetTime();
                    welcome3.Listact();
                    break;
                case 4:
                    Console.Clear();
                    Thought welcome4 = new Thought("Welcome to the Thought Activity\n", "This activity will help you control your thoughts to clean our mind.\n", "Thought Activity.\n");
                    Console.WriteLine(welcome4.GetWelcome());
                    Console.WriteLine(welcome4.GetMessage());
                    welcome4.GetTime();
                    welcome4.CtrlThought();
                    
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