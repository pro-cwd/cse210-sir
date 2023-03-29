using System;

class Program
{
    static void Main(string[] args)
    {
        int points = 0;
        MenuOption options = new MenuOption();
        List<Dictionaries> newListWords = new List<Dictionaries>();
        bool myBool = true;
        do
        {   
            Console.WriteLine("\nWelcome to the Learn new  Words in English Program\n");
            Console.WriteLine("Menu Options: ");
            string[] menuOp = {"1. New Word", "2. List Sentences", "3. Save Words", "4. Load Words", "5. Test of words", "6. Practice", "7. Quit"};
            options._MenuOptions(menuOp);

            Console.Write("\nSelect a choice from the menu: ");
            string num = Console.ReadLine();
            int numberElect = int.Parse(num);
            switch(numberElect)
            {
                case 1:
                    Console.Write("Pleace type the new word: ");
                    string newWord = Console.ReadLine();
                    Console.Write("Write a sentence related with the word: ");
                    string sentence = Console.ReadLine();
                    Process wordS = new Process(newWord, sentence, points);
                    newListWords.Add(wordS);
                break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("The words and sentences are:");
                    int count = 1;
                    foreach (Dictionaries nws in newListWords)
                        {
                            Console.Write($"\n{count}. ");
                            nws.GetWords();
                            count++;
                        }
                break;
                case 3:
                    Console.WriteLine("Whats is the filename? ");
                    string dictFile = Console.ReadLine();
                    
                    using (StreamWriter outputFile = new StreamWriter(dictFile))
                    {
                        outputFile.WriteLine();
                        foreach (Dictionaries dict in newListWords)
                        {
                            outputFile.WriteLine(dict.WriteFile());
                        }
                    }
                break;
                case 4:
                    Console.WriteLine("What is the filename for the words? ");
                    string file = Console.ReadLine();
                    string[] lines = System.IO.File.ReadAllLines(file);

                    foreach (string line in lines)
                    {
                        char[] delimiterChars = {'|'};
                        string[] parts = line.Split(delimiterChars);
                        
                        Process randSens = new Process(parts[0], parts[1], points);
                        newListWords.Add(randSens);
                    }
                break;
                case 5:
                    Console.WriteLine("\nCHOOSE A TEST\n");
                    string[] menuOp2 = {"1. Easy Test", "2. Hard Test"};
                    options._MenuOptions(menuOp2);

                    Console.Write("\nSelect a choice from the menu: ");
                    string num2 = Console.ReadLine();
                    int testElect = int.Parse(num2);
                    if (testElect == 1)
                    {
                        Console.Clear();
                        string file1 = "dict.txt";
                        Console.WriteLine("EASY TEST:\n");
                        Words word = new Words(file1);
                        Console.WriteLine();
                        Console.WriteLine("\nPress enter to continue:");
                        string input = Console.ReadLine();
                        RandomSentence sentens = new RandomSentence(file1);
                        sentens._RandomSent();
                    }
                    else if (testElect == 2)
                    {
                        Console.Clear();
                        string file2 = "dict2.txt";
                        Console.WriteLine("HARD TEST:\n");
                        Words word = new Words(file2);
                        Console.WriteLine();
                        Console.WriteLine("\nPress enter to continue:");
                        string input2 = Console.ReadLine();
                        RandomSentence sentens = new RandomSentence(file2);
                        sentens._RandomSent();
                    }
                    else
                    {
                        Console.WriteLine("There is no any words storage. Pleace save a some words first");
                    }

                break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("PRACTICE YOUR ENGLISH\n");
                    Console.WriteLine("\"Read and memorize the sentences.\"");
                    string pFile1 = "dict.txt";
                    string pFile2 = "dict2.txt";
                    PracticeMode practiceFile = new PracticeMode(pFile1, pFile2);

                break;
                case 7:
                 myBool = false;
                break;
                default:
                    Console.WriteLine("Pleace enter a number 1 to 7");
                break;
            }

            

        }while (myBool);




    }
}