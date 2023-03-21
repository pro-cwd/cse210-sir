using System;

class Program
{
    static void Main(string[] args)
    {
        MenuOption options = new MenuOption();
        bool myBool = true;
        do
        {   
            Console.Clear();
            Console.WriteLine("Welcome to the Learn new  Words in English Program\n");
            Console.WriteLine("Menu Options: ");
            string[] menuOp = {"1. New Words", "2. List Sentences", "3. Save Words", "4. Load Words", "5. Test of words", "6. Practice", "7. Quit Words"};
            options._MenuOptions(menuOp);

            Console.Write("\nSelect a choice from the menu: ");
            string num = Console.ReadLine();
            int numberElect = int.Parse(num);
            switch(numberElect)
            {
                case 1:
                break;
                case 2:
                break;
                case 3:
                break;
                case 4:
                break;
                case 5:
                break;
                case 6:
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