public class Reference
{
    private string[] chapterJn = {"John 1", "John 2", "John 3"};
    private string[] chapterGs = {"Galatians 1", "Galatians 2", "Galatians 3"};
    private string[] chapterJm = {"James 1", "James 2", "James 3"};

    string j = "John";
    string g = "Galatians";
    string ja = "James";

    public string _num = "";
    public int _numberElect;
    public string chapter = "";

    public string References()
    {
    if (_num == j || _numberElect == 1) 
        {
            Console.WriteLine("\nJohn Chapters");
            foreach (string i in chapterJn)
                {
                    Console.WriteLine(i);
                }
            Console.Write("Please choose a chapter:");
            string chap = Console.ReadLine();
            int chapter = int.Parse(chap);

        } else if (_num == g || _numberElect == 2)
            {
                Console.WriteLine("\nGalatians Chapters");
                foreach (string i in chapterGs)
                    {
                        Console.WriteLine(i);
                    }
                Console.Write("Please choose a chapter:");
                string chap = Console.ReadLine();
                int chapter = int.Parse(chap);
                // Console.WriteLine(chapGlans);

            } else if (_num == ja || _numberElect == 3)
                {
                    Console.WriteLine("\nJames Chapters");
                    foreach (string i in chapterJm)
                        {
                            Console.WriteLine(i);
                        }
                    Console.Write("Please choose a chapter:");
                    string chap = Console.ReadLine();
                    int chapter = int.Parse(chap);
                    // Console.WriteLine(chapJames);
                } 
    else
        {
            Console.WriteLine("Please introduce the corret requirement");
        }
        return chapter;   
    }

}