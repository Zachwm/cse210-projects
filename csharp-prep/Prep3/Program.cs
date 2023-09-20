// Random Number Guessing Game
// CSE 210
// Zach McLaughlin
// Generates a number giving the user unlimited attempts at guessing the int 1-10

using System;

class Program
{
    static void Main(string[] args)
    {   
        bool zmDone = false;

        Random zmRnd = new Random();
        int zmAnswer  = zmRnd.Next(1, 10);
        
        while (!zmDone)
        {
        Console.Write("What is your guess? ");
        string zmGuessString = Console.ReadLine();
        int zmGuessInt = int.Parse(zmGuessString);

        if (zmGuessInt == zmAnswer)
        {
            Console.Write("You guessed it!");
            zmDone = true;
        }
        else if (zmGuessInt < zmAnswer)
        {
            Console.WriteLine("Higher");
        }
        else if (zmGuessInt > zmAnswer)
        {
            Console.WriteLine("Lower");
        }
        }
    }
}