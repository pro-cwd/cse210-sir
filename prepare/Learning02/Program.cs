using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!\n");

        Resume resume = new Resume();
        resume._name = "Alis in Chains";
        resume.Display();

        Job job1 = new Job();
        job1._company = "Google";
        job1._jobTitle = "Web Developer";
        job1._startYear = 2023;
        job1._endYear = 2030;
        job1.Display();

        Job job2 = new Job();
        job2._company = "Apple";
        job2._jobTitle = "Manager";
        job2._startYear = 2018;
        job2._endYear = 2023;
        job2.Display();

    }
}