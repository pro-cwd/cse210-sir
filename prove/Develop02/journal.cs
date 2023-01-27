using System;

public class Journal
{
        // string date = "";
        // string question = "";
        // string answ = "";
        public List<Entry> _entries = new List<Entry>();
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

                  Console.WriteLine(parts[0]);
                }

        }
        
}