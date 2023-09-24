// Name and favorite number
// CSE 210
// Zach McLaughlin
// takes the name and favorite number of the user and dispays their name back along with the square of their favorite number

using System;

class Program
{
    static void Main(string[] args)
    {

        zmMain();
    }

    static void zmMain()
    {
        zmDisplayWelcome();
        string zmName = zmPromptUserName();
        int zmNumber = zmPromptUserNumber();
        double zmSquaredNumber = SquareNumber(zmNumber);
        DisplayResult(zmName, zmSquaredNumber);
    }

    static void zmDisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string zmPromptUserName()
    {
        Console.Write("Please enter username: ");
        string zmUsername = Console.ReadLine();
        return zmUsername;
    }
    static int zmPromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string zmNumString = Console.ReadLine();
        int zmNumInt = int.Parse(zmNumString);
        return zmNumInt;
    }
    static double SquareNumber(int zmNumber)
    {
        double zmNumSquared = zmNumber * zmNumber;
        return zmNumSquared;
    }
    
    static void DisplayResult(string zmName, double zmSquaredNumber);
    {
        Console.WriteLine($"{zmName}, the square of your number is {zmSquaredNumber}");
    }
}