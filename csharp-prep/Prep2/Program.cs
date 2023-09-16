using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string gradeString = Console.ReadLine();
        int gradeInt = int.Parse(gradeString);

        string gradeLetter;

        if (gradeInt >= 90)
        {
            gradeLetter = "A";
        }
        else if (gradeInt >= 80)
        {
            gradeLetter = "B";
        }
        else if (gradeInt >= 70)
        {
            gradeLetter = "C";
        }
        else if (gradeInt >= 60)
        {
            gradeLetter = "D";
        }
        else
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is: {gradeLetter}");
    }
}