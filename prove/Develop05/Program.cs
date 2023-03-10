using System;

class Program
{
    static void Main(string[] args)
    {
        Goal menuOptions = new Goal();
        Goal readGoals = new Goal();
        List<Goal> goals = new List<Goal>();

        bool myBool = true;
        do
        {
            Console.WriteLine("\nYou Have 0 points\n");
            Console.WriteLine("Menu Options:");
            string[] choices = {"1. Create new Goal", "2. List Goals", "3. Save goals", "4. Load Goals", "5. Record Events", "6. Quit"};
            menuOptions.MenuOptions(choices);

            Console.Write("Select a choice from the menu: ");
            string num = Console.ReadLine();
            int numberElect = int.Parse(num);
            switch(numberElect)
            {
                case 1:
                    Console.WriteLine("The types of Goals are:");
                    string[] choices1 = {"1. Simple Goal", "2. Eternal Goal", "3. CheckList Goal"};
                    menuOptions.MenuOptions(choices1);

                    Console.Write("Which type of goal would you like to crate: ");
                    string num1 = Console.ReadLine();
                    int _typeGoal = int.Parse(num1);

                    if (_typeGoal == 1)
                    {
                        Console.Write("What is the name of your goal? ");
                        string name = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string description = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        string amount = Console.ReadLine();

                        SimpleGoal simpleGoal = new SimpleGoal(name, description, amount);
                        goals.Add(simpleGoal);

                    } else if (_typeGoal == 2)
                        {
                            Console.Write("What is the name of your goal? ");
                            string name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            string amount = Console.ReadLine();

                            EternalGoal eternalGoal = new EternalGoal(name, description, amount);
                            goals.Add(eternalGoal);

                        } else if (_typeGoal == 3)
                            {
                                Console.Write("What is the name of your goal? ");
                                string name = Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                string description = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal? ");
                                string amount = Console.ReadLine();
                                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                                string bonus = Console.ReadLine();
                                int bonusa = int.Parse(bonus);

                                CheckGoal checkGoal = new CheckGoal(name, description, amount, bonusa);
                                goals.Add(checkGoal);

                            } else
                                {
                                    Console.WriteLine("pleace select a number from 1 to 3");
                                }
                    break;
                case 2:
                    // Console.Clear();
                    Console.WriteLine("The goals are:");
                    int i = 0;
                    foreach (Goal show in goals)
                    {
                        string name = show.GetName();
                        string description = show.GetDescription();
                        i++;
                        string a = "";

                        Console.WriteLine($"{i}. [ {a} ] {name} ({description})");
                    }

                    break;
                case 3:
                    Console.WriteLine("Whats is the filename for the goal file? ");
                    string goalFile = Console.ReadLine();
                    using (StreamWriter outputFile = new StreamWriter(goalFile))
                        {
                            foreach ( Goal entry in goals)
                            {
                                outputFile.WriteLine($"{entry.GetType()}:{entry._nameGoal},{entry._descriptionGoal},{entry._amountGoal}");
                            }
                        }

                    break;
                case 4:
                    Console.WriteLine("What is the filename for the goal file? ");
                    string file = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(file);

                    foreach (string line in lines)
                    {
                        char[] delimiterChars = {':','-',','};
                        string[] parts = line.Split(delimiterChars);

                        // readText._dateText = parts[0].Trim();
                        readGoals._nameGoal = parts[1].Trim();
                        readGoals._descriptionGoal = parts[2].Trim();
                        readGoals._amountGoal = parts[3].Trim();
                        goals.Add(readGoals);
                    }
                     Console.WriteLine(" ");

                break;
                case 5:
                    Console.WriteLine("The goals are:");
                    int x = 0;
                    foreach (Goal show in goals)
                    {
                        string name = show.GetName();
                        x++;
                        Console.WriteLine($"{x}. {name}");
                    }
                    Console.Write("Which goal did you accomplish? ");
                    string num2 = Console.ReadLine();
                    int _goalAcomplish = int.Parse(num2);



                break;
                case 6:
                    myBool = false;
                    break;
                default:
                    Console.WriteLine("Pleace enter a number 1 to 5");
                    break;
            }
        } while (myBool);


    }
}