
using System;

public class PromptGenerator
{
        // public PromptGenerator()
        // {}

        public string ShowPrompt()
         {
            Random rand = new Random();
                string[] questions = {"What was the best part of my day?", "What are you grateful for today?", "What made you happy today?", "What have you learned today?", "Have I done any good today?", "Who was the most interesting person I interacted with today?", "What was the best part of my day?", "How did I see the hand of the Lord in my life today?", "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"};
                int randIndex = rand.Next(questions.Length);
                Console.WriteLine(questions[randIndex]);
                string randd = questions[randIndex];
                return randd;
        }
}
