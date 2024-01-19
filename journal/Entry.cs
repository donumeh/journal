using System;

public class Entry
{
    // Class Attributes
    public string _entryText; // Saved entry texts
    public string _date; // Current date of input
    public string _promptText; // prompt generated


    public Entry()
    { // Constructor
    }

    public void Display()
    {
        Console.WriteLine($"{_entryText}");
        Console.WriteLine($"----------------------------------------");
        Console.WriteLine($"{_date}");
        Console.WriteLine($"----------------------------------------\n");

        Console.WriteLine($"Entry:");
        Console.WriteLine($"{_entryText}");
    }

}