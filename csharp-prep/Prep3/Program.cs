using System;

class Program
{
    static void Main(string[] args)
    {
        string yes_no = "yes";
        Console.WriteLine("Hello Prep3 World!");
        // import random
        Console.WriteLine("GUESS THE NUMBER");
        Random randomGenerator = new Random();
        int num_magic = randomGenerator.Next(1, 101);

        //As long as they say "yes" we will keep playing
        while (yes_no == "yes")
        {   
            int num_guess;
            int i = 0;
            Console.Write("What is your guess?  ");
            num_guess = int.Parse(Console.ReadLine());
            while (num_guess != num_magic)
            {
                // i < num_guess_run;
                 i ++;
                if (num_guess > num_magic)
                {
                    Console.WriteLine("lower");
                    Console.Write("What is your guess?  ");
                    num_guess = int.Parse(Console.ReadLine());
                }
                else if (num_guess < num_magic)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess?  ");
                    num_guess = int.Parse(Console.ReadLine());
                }
            }
            while (num_guess == num_magic)
            {
                Console.WriteLine("You guessed it!");
                Console.WriteLine($"The magic number is {num_magic}");
                Console.WriteLine($"Your number of guesses were of {i}");
                break;
            }
            Console.Write("Would you like to play again (yes/no)? ");
            yes_no = Console.ReadLine();
        }

        /*'''attempt = 5
        for i in range(5):
            user_input = int(input('Enter Number: '))
            num_magic = int(random.randrange(1, 100))
        if user_input == num_magic:
            print('You won!')
            break
        else:
        print(f'Try again! {attempt} left.')
        attempt -= 1
        continue'''*/


    }
}