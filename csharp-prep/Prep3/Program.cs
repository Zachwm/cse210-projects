using System;

class Program
{
    static void Main(string[] args)
    {   
        bool done = false;

        Random rnd = new Random();
        int answer  = rnd.Next(1, 10);
        
        while (!done)
        {
        Console.Write("What is your guess? ");
        string guessString = Console.ReadLine();
        int guessInt = int.Parse(guessString);

        if (guessInt == answer)
        {
            Console.Write("You guessed it!");
            done = true;
        }
        else if (guessInt < answer)
        {
            Console.WriteLine("Higher");
        }
        else if (guessInt > answer)
        {
            Console.WriteLine("Lower");
        }
        }
    }
}