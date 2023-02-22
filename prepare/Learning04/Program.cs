// using System;

// class Program
// {
//     static void Main(string[] args)
//     {
//         Console.WriteLine("Hello Learning04 World!\n");

//         Assignment name = new Assignment();
//         name.GetSummary("Omar Meza", "JavasCript");

//         MathAssognment homework = new MathAssognment();
//         homework.GetSummary("Diana Flores", "diseño grafico");
//         homework.GetHomeworkList("7.3", "8-9");

//         WriteAssignment write = new WriteAssignment();
//         write.GetSummary("Nefertiti Meza", "baile");
//         write.GetWritingInFormation("The Causes of World War II by Mary Waters");







//     }
// }



using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a base "Assignment" object
        Assignment a1 = new Assignment("Samuel Bennett", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        // Now create the derived class assignments
        MathAssignment a2 = new MathAssignment("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}