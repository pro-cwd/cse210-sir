using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        int points = 0;
        List<Goal> goals = new List<Goal>();

        bool myBool = true;
        do
        {
            Console.WriteLine($"\nYou Have {points} points\n");
            Console.WriteLine("Menu Options:");
            string[] choices = {"1. Create new Goal", "2. List Goals", "3. Save goals", "4. Load Goals", "5. Record Events", "6. Quit"};
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
                    Console.WriteLine("The types of Goals are:");
                    string[] choices1 = {"1. Simple Goal", "2. Eternal Goal", "3. CheckList Goal"};
                     foreach (string i in choices)
                    {
                        Console.WriteLine(i);
                    }

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
                        string amt = Console.ReadLine();
                        int amount = int.Parse(amt);

                        SimpleGoal simpleGoal = new SimpleGoal(name, description, amount);
                        goals.Add(simpleGoal);

                    } else if (_typeGoal == 2)
                        {
                            Console.Write("What is the name of your goal? ");
                            string name = Console.ReadLine();
                            Console.Write("What is a short description of it? ");
                            string description = Console.ReadLine();
                            Console.Write("What is the amount of points associated with this goal? ");
                            string amt = Console.ReadLine();
                            int amount = int.Parse(amt);

                            EternalGoal eternalGoal = new EternalGoal(name, description, amount);
                            goals.Add(eternalGoal);

                        } else if (_typeGoal == 3)
                            {
                                Console.Write("What is the name of your goal? ");
                                string name = Console.ReadLine();
                                Console.Write("What is a short description of it? ");
                                string description = Console.ReadLine();
                                Console.Write("What is the amount of points associated with this goal? ");
                                string amt = Console.ReadLine();
                                int amount = int.Parse(amt);
                                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                                string bonusOn = Console.ReadLine();
                                int bonusOne = int.Parse(bonusOn);
                                Console.Write("What is the bonus for accomplishing it that many times? ");
                                string bonusa = Console.ReadLine();
                                int bon = int.Parse(bonusa);

                                CheckGoal checkGoal = new CheckGoal(name, description, amount, bonusOne, bon);
                                goals.Add(checkGoal);

                            } else
                                {
                                    Console.WriteLine("pleace select a number from 1 to 3");
                                }
                    break;
                case 2:
                    // Console.Clear();
                    Console.WriteLine("The goals are:");
                    int count = 1;
                    foreach (Goal gl in goals)
                        {
                            Console.Write($"{count}. ");
                            gl.ReturnGoal();
                            count++;
                        }

                    break;
                case 3:
                    Console.WriteLine("Whats is the filename for the goal file? ");
                    string goalFile = Console.ReadLine();
                    
                    if(!File.Exists(goalFile))
                    {
                        using (StreamWriter outputFile = new StreamWriter(goalFile))
                        {
                            outputFile.WriteLine(points);
                            foreach (Goal gl in goals)
                            {
                                outputFile.WriteLine(gl.WriteFile());
                            }
                        }
                    }

                    else 
                    {
                        using (StreamWriter outputFile = File.AppendText(goalFile))
                        {
                            outputFile.WriteLine(points);
                            foreach (Goal gl in goals)
                            {
                                outputFile.WriteLine(gl.WriteFile());
                            }
                        }
                    }

                    break;
                case 4:
                    Console.WriteLine("What is the filename for the goal file? ");
                    string file = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(file);

                    foreach (string line in lines)
                    {
                        char[] delimiterChars = {'|'};
                        string[] parts = line.Split(delimiterChars);
                        
                        string f0 = "|SimpleGoal|EternalGoal|CheckGoal|";
                        string[] f1 = f0.Split(delimiterChars); 
                        
                        //Console.WriteLine(String.Equals(f1[1], parts[1]));
                        if(String.Equals("SimpleGoal", parts[0]))
                        {
                            int newPoints = int.Parse(parts[3]);
                            bool completedS = bool.Parse(parts[4]);
                            SimpleGoal newGoalS = new SimpleGoal(parts[1], parts[2], newPoints, completedS);
                            goals.Add(newGoalS);
                        }
                        else if(String.Equals("EternalGoal", parts[0]))
                        {
                            int newPoints = int.Parse(parts[3]);
                            EternalGoal newGoalE = new EternalGoal(parts[1], parts[2], newPoints);
                            goals.Add(newGoalE);
                        }
                        else if(String.Equals("CheckGoal", parts[0]))
                        {
                            int newPoints = int.Parse(parts[3]);
                            int times = int.Parse(parts[4]);
                            int bonus = int.Parse(parts[5]);
                            CheckGoal newGoalC = new CheckGoal(parts[1], parts[2], newPoints, times, bonus);
                            goals.Add(newGoalC);
                        }
                        else
                        {
                            points = int.Parse(parts[0]);
                        }
                    }

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