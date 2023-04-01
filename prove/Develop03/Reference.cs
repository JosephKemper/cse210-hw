using System;
/*
Reference Class
Purpose: Handles the display of a scripture reference. 
Inputs: raw scripture reference
Outputs: formatted scripture reference
Think the address class that I wrote for several other programs
*/

public class Reference
{
    private string _reference;
    public void PrepReference(string reference)
    {
        _reference =reference;
    }

    public void DisplayReference()
    {
        Console.WriteLine(_reference);
    }
}