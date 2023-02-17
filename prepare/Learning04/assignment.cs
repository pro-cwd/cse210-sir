public class Assignment
{
    protected string _studentName = "";
    protected string _topic = "";

    public void GetSummary(string name, string topic)
    {   
        _studentName = name;
        _topic = topic;

        // Console.WriteLine($"{name} - {topic}");
    }
}