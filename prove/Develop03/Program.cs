using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!\n");


        string[] content = {"John 1", "John 2", "john 3"};
        Console.WriteLine("\"Welcome to the Scripture Memorizer\"\n");

        Console.WriteLine("Scripture of New Testament:");
        foreach (string i in content)
            {
                Console.WriteLine(i);
            }
        Console.Write("Please select a Chapter: ");
        string chapter = Console.ReadLine();
        int numberElect = int.Parse(chapter);

        Reference refer = new Reference();
        refer._numberElect = numberElect;
        refer.References();
        
        // Scripture scrip = new Scripture();
        // scrip.


    }
}