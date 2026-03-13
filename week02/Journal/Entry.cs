using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        int wordCount = _entryText.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;

        Console.WriteLine("-----------------------------------");
        Console.WriteLine($"Date: {_date}");
        Console.WriteLine($"Prompt: {_promptText}");
        Console.WriteLine($"Response: {_entryText}");
        Console.WriteLine($"Word Count: {wordCount}");
        Console.WriteLine("-----------------------------------");
    }
}