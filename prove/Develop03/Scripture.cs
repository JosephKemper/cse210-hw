using System;
namespace Develop03;

public class Scripture
{
    
    private List<string> _wordList = new List<string> ();
    private string _currentReference;
    private string _currentText;


    
    
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