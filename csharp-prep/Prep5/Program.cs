// 
// CSE 210
// Zach McLaughlin
// 

using System;

class Program
{
    static void Main(string[] args)
    {
        void zmMain()
        {
            zmDisplayWelcome();
            string zmName = zmPromptUserName();
            int zmNumber = zmPromptUserNumber();
            double zmSquaredNumber = SquareNumber(int zmNumber);
            DisplayResult(string zmName, double zmSquaredNumber);

        }
        void zmDisplayWelcome()
        {
            Console.WriteLine("Welcome to the Program!");
        }
        string zmPromptUserName()
        {
            Console.Write("Please enter username: ");
            string zmUsername = Console.ReadLine();
            return zmUsername;
        }
        int zmPromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            string zmNumString = Console.ReadLine();
            int zmNumInt = int.Parse(zmNumString);
            return zmNumInt;
        }
        double SquareNumber(zmNumber)
        {
            double zmNumSquared = zmNumber * zmNumber;
            return zmNumSquared;
        }
        void DisplayResult(zmName,  zmSquaredNumber);
        {
            Console.WriteLine($"{zmName}, the square of your number is {zmSquaredNumber}");
        }

        zmMain();
    }
}