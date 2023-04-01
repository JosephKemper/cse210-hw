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
    private List <string> _scriptureList = new List<string>();

    public void LoadScriptures ()
    {
        foreach (string line in File.ReadLines(_scriptureFile))
        {
            _scriptureList.Add(line);
        }
    }

    public void SelectScripture()
    {
        _selectedScripture =1;
    }

    public void DisplayScripture()
    {
        Console.WriteLine (_scriptureList[_selectedScripture]);
    }
}