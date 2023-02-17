using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!\n");

        Assignment name = new Assignment();
        name.GetSummary("Omar Meza", "JavasCript");

        MathAssognment homework = new MathAssognment();
        homework.GetSummary("Diana Flores", "diseño grafico");
        homework.GetHomeworkList("7.3", "8-9");

        WriteAssignment write = new WriteAssignment();
        write.GetSummary("Nefertiti Meza", "baile");
        write.GetWritingInFormation("The Causes of World War II by Mary Waters");







    }
}