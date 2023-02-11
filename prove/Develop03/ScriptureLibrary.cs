using System;
// learned about namespace from https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/tutorials/classes
namespace ScriptureProject;
public class ScriptureLibrary
{
    // Stretch Goal loads scriptures from file for use in program
    
    private List <string> _referenceList = new List <string> ();
    private List <string> _scriptureList = new List<string> ();
    private string scriptureFile = "Scripture Library.txt";
    
    public void LoadScriptures()
    {
        
        // Stretch Goal loads scriptures from file into list
        string[] lines = System.IO.File.ReadAllLines(scriptureFile);
        foreach (string line in lines)
        {
            string[] scriptureParts = line.Split("|~|");
            string reference = scriptureParts [0];
            string text = scriptureParts [1];

            _scriptureList.Add(text);
            _referenceList.Add(reference);
        }
    }

    public List<string> ReturnReference()
    {
        return _referenceList;
    }

    public List<string> ReturnText()
    {
        return _scriptureList;
    }

}