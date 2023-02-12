using System;
namespace Develop03;

public class Scripture
{
    
    private List<string> _wordList = new List<string> ();
    private string _currentReference;
    private string _currentText;

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
    
    // method for converting array to list found https://www.c-sharpcorner.com/article/convert-an-array-to-a-list-in-c-sharp/
    public void ConstructWordList ()
    {
        string [] _wordArray = _currentText.Split(" ");
        _wordList.AddRange(_wordArray);
    }
        
         
    
    
    

    public string DisplayReference ()
    {
        Reference scriptureReference = new Reference();
            
        _currentReference = scriptureReference.ReturnReference();
        return _currentReference;
     }

     public string DisplayVerse ()
     {
        return _currentText;
     }

    /*
    The word list that will store the verse text, 
    will need to be regularly updated with underscores 
    as each word slowly gets replaced by underscores, 
    and then recombined back into a string and 
    then combined back with the reference to be shown to the user.
    */
}