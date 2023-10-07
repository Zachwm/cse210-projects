// Journal
// CSE 210
// Zach McLaughlin
// An application that promts the user for a journal entry allowing the entry to be saved to a file and later loaded
// I completed exceeding expectations by correctly saving the journal into a csv file taking into account the possibility of any commas in their input

using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menuDisplay = new Menu();
        menuDisplay.DisplayMenu();

    }
}