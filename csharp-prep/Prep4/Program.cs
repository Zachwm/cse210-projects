// Compute List of Numbers
// CSE 210
// Zach McLaughlin
// Takes a list of numbers from the user giving the sum, average, and largest number

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        string zmNumString;
        int zmNumInt;
        List<int> zmNumbers = new List<int>();

        do
        {   
            Console.Write("Enter number: ");
            zmNumString = Console.ReadLine();
            zmNumInt = int.Parse(zmNumString);
            if (zmNumInt != 0)
            {
                zmNumbers.Add(zmNumInt);
            }
        }   while (zmNumInt != 0);

        int zmSum = zmNumbers.Sum();
        double zmAvg = zmNumbers.Average();
        int zmLgst = zmNumbers.Max();

        Console.WriteLine($"The sum is: {zmSum}");
        Console.WriteLine($"The average is: {zmAvg}");
        Console.WriteLine($"The largest number is: {zmLgst}");
    }
}