
// class WriteAssignment : Assignment
// {
//     public string _title = "";

//     public void GetWritingInFormation(string title)
//     {
//         _title = title;

//         Console.WriteLine($"{_studentName} - {_topic}");
//         Console.WriteLine($"{title}");
//     }

// }

public class WritingAssignment : Assignment
{
    private string _title;

    // Notice the syntax here that the WritingAssignment constructor has 3 parameters and then
    // it passes 2 of them directly to the "base" constructor, which is the "Assignment" class constructor.
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        // Here we set any variables specific to the WritingAssignment class
        _title = title;
    }

    public string GetWritingInformation()
    {
        // Notice that we are calling the getter here because _studentName is private in the base class
        string studentName = GetStudentName();

        return $"{_title} by {studentName}";
    }
}