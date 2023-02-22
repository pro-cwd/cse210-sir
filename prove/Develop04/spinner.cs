using System;

public class Spinner
{
    public Spinner()
    {
        bool threadRun = true;
        int i = 0;
        while (threadRun)
        {
            Thread.Sleep(500);
            switch (i)
            {
                case 0:
                    Console.Write("\b \b");
                    Console.Write("|");
                    i = 1;
                    break;
                case 1:
                    Console.Write("\b \b");
                    Console.Write("/");
                    i = 2;
                    break;
                case 2:
                    Console.Write("\b \b");
                    Console.Write("-");
                    i = 3;
                    break;
                case 3:
                    Console.Write("\b \b");
                    Console.Write("|");
                    i = 4;
                    break;
                case 4:
                    Console.Write("\b \b");
                    Console.Write("/");
                    i = 5;
                    break;
                case 5:
                    Console.Write("\b \b");
                    Console.Write("-");
                    i = 6;
                    break;
                case 6:
                    Console.Write("\b \b");
                    Console.Write("|");
                    i = 7;
                    break;
            }
        }
    }
}