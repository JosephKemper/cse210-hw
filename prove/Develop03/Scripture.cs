using System;
/*
Scripture Class
Purpose: 
Handles the selection and display of a scripture. 
Uses the reference class for displaying the reference, 
and the word class for hiding a scripture. 
Inputs: 
A file containing a list of scriptures. 
Outputs: 
A scripture, and its reference to displayed to the screen. 
*/

public class Scripture
{
    private string _scriptureFile = "Scripture Library.txt";
    private int _selectedScripture;
    private string _unformattedScripture;
    private int _listLength;
    private List <string> _scriptureList = new List<string>();

    public void LoadScriptures ()
    {
        foreach (string line in File.ReadLines(_scriptureFile))
        {
            _scriptureList.Add(line);
        }
    }
    //Stretch Exceeding Requirements select a random scripture from a list.
    public void SelectScripture()
    {
        Random randomIndex = new Random();
        _listLength = _scriptureList.Count;
        _selectedScripture = randomIndex.Next(1,_listLength+1);
        _unformattedScripture = _scriptureList[_selectedScripture];
    }

    public void PrepScripture()
    {
        Reference newReference = new Reference();
        string [] parts = _unformattedScripture.Split("|~|");
        newReference.PrepReference(parts[0]);

        DisplayScripture(parts[0], parts[1]);
    }

    public void DisplayScripture(string reference, string verse)
    {
        Console.WriteLine ($"{reference} {verse}");
    }
}