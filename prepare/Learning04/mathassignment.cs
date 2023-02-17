
 public class MathAssognment : Assignment
{
    
    private string _textbookSection = "";
    private string _problems = "";

    public void GetHomeworkList(string section, string problems)
    {
        _textbookSection = section;
        _problems = problems;

        // Console.WriteLine($"{_studentName} - {_topic}");
        // Console.WriteLine($"Section {section} Problems {problems}");

    }


}