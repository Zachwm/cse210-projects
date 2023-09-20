using System;

class Program
{
    static void Main(string[] args)
    {   
        bool done = false;

        Console.Write("What is the magic number? ");
        string answerString = Console.ReadLine();
        int answerInt = int.Parse(answerString);
        
        while (!done)
        {
        Console.Write("What is your guess? ");
        string guessString = Console.ReadLine();
        int guessInt = int.Parse(guessString);

        if (guessInt == answerInt)
        {
            Console.Write("You guessed it!");
            done = true;
        }
        else if (guessInt < answerInt)
        {
            Console.WriteLine("Higher");
        }
        else if (guessInt > answerInt)
        {
            Console.WriteLine("Lower");
        }
        }
    }
}