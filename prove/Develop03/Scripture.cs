using System;
using System.Linq;
using System.IO;

public class Scripture
{
    
    /*
    Keeps track of the reference and the text of the scripture. 
    Can hide words and get the rendered display of the text.
    */
    private string _combinedReference;
    string _verseText = "Therefore, fear not, little flock; do good; let earth and hell combine against you, for if ye are built upon my rock, they cannot prevail. Behold, I do not condemn you; go your ways and sin no more; perform with soberness the work which I have commanded you. Look unto me in every thought; doubt not, fear not.";
    // method for converting array to list found https://www.c-sharpcorner.com/article/convert-an-array-to-a-list-in-c-sharp/
    public void constructWordList ()
    {
        string [] _wordArray = _verseText.Split(" ");
        List <string> _wordList = new();
        _wordList.AddRange(_wordArray);
        
    }
        
         
    
    
    // VisibleVerseList:List <String>

    // Hide Words -- uses the hide function in the word class to hide each word as needed. 
    
    // Get Rendered Text -- assembles the modified verse for display to user

    // Set Rendered Text -- Displays rendered text to user
    // Is Completely Hidden -- checks if the verse is completely hidden and exits the program after another input from user


    // combine scripture -- combines the reference, and text of the scripture to one string
    // display text -- display's the scripture text to the user.

    public string DisplayReference ()
    {
        Reference scriptureReference = new Reference();
            
        _combinedReference = scriptureReference.ReturnReference();
        return _combinedReference;
     }

     public string DisplayVerse ()
     {
        return _verseText;
     }

    /*
    The word list that will store the verse text, 
    will need to be regularly updated with underscores 
    as each word slowly gets replaced by underscores, 
    and then recombined back into a string and 
    then combined back with the reference to be shown to the user.
    */
}