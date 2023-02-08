using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop03 World!\n");


        string[] content = {"1. John", "2. Galatians", "3. James"};
        Console.WriteLine("\"Welcome to the Scripture Memorizer\"\n");

        Console.WriteLine("Scripture of New Testament:");
        foreach (string i in content)
            {
                Console.WriteLine(i);
            }
        Console.Write("Please select a Scripture: ");
        string num = Console.ReadLine();
        int numberElect = int.Parse(num);

        Reference refer = new Reference();
        refer._num = num;
        refer._numberElect = numberElect;
        refer.References();
        
        // Scripture scrip = new Scripture();
        // scrip.


    }
}