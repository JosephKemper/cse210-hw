using System;
/*
Reference Class
Purpose: Handles the formatting of a scripture reference. 
Inputs: raw scripture reference
Outputs: formatted scripture reference
Think the address class that I wrote for several other programs
*/

public class Reference
{
    private string _reference;
    public string PrepReference(string reference)
    {
        _reference =reference;
        return _reference;
    }
}