using System;

public class ScriptureLibrary
{
    // Stretch Goal loads scriptures from file for use in program
    private string scriptureFile = "Scripture Library.txt";
    private List <string> _referenceList = new List <string> ();
    private List <string> _scriptureList = new List<string> ();
    public void LoadScriptures ()
    {
        // Stretch Goal loads scriptures from file into list
        string[] lines = System.IO.File.ReadAllLines(scriptureFile);
        foreach (string line in lines)
        {
            
        }
    }


}