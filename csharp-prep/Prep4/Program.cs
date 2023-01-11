using System.Collections.Generic;
using System.Linq;

class Program
{   
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");

        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        
        int enter_number;
        int maxnum = 0;
        do
        {
            Console.Write("Enter number: ");
            enter_number = int.Parse(Console.ReadLine());
            numbers.Add(enter_number);
        } while (enter_number != 0);
        int nums;
        int sum = numbers.Sum();
        numbers.RemoveAt(numbers.Count - 1);
        nums = numbers.Count;
        // int div = int.Parse(nums);
        double average = sum/nums;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        foreach (int num in numbers)
        {
            if (num > maxnum)
            {
                maxnum = num;
            }
        }
        Console.WriteLine($"The largest number is: {maxnum}");
        Console.WriteLine(String.Join(" ", numbers));
    }
}