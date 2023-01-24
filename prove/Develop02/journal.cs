using System;

public class Journal
{
        // string date = "";
        // string question = "";
        // string answ = "";

        public Journal()
        {
        }

        public void Display()
        {
        string filename = "myFile.txt";
        string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(",");

                //     string date = parts[0];
                //     string question = parts[1];
                //     string answ = parts[2];
                    
                  Console.WriteLine(parts[0]);
                }

        }
        
}