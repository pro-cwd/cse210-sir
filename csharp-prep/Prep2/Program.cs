using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage?  ");
        string grade = Console.ReadLine();
        int percent = int.Parse(grade);
        float last_num = percent % 10;
        Console.WriteLine($"{last_num}");
        string letter = "";
        if (percent >= 90)
        {
        letter = "A";
        }
        else if (percent >= 80)
        {
        letter = "B";
        }
        else if (percent >= 70)
        {
        letter = "C";
        }
        else if (percent >= 60)
        {
        letter = "D";
        }
        else
        {
        letter = "F";
        }
        // Stretch Challenge 1
        string sign = "";

         //last_num = grade % 10

        if (last_num >= 7)
        {
        sign = "+";
        }
        else if (last_num < 3)
        {
        sign = "-";
        }
        else
        {
        sign = "";
        }
        // Stretch Challenge 2
        if (percent >= 93)
        {
        sign = "";
        }
        // Stretch Challenge 3
        if (letter == "F")
        {
        sign = "";
        Console.WriteLine($"Your letter grade is: {letter}{sign}");
        // string fname = Console.ReadLine();
        }

        if (percent >= 70)
        {
        Console.WriteLine("Congrats you have passed!");
        }
        else 
        {
        Console.WriteLine("You dont have passed... Dont worry, try you again for next time.");
        }
    }
}