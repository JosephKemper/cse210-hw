using System;
namespace Develop03;

public class Reference
{
    // Selects and returns scripture reference for user to memorize
    private List<string> _referenceList = new List<string>();
    private List<string> _textList = new List<string> ();
    private string _scriptureReference;
    private string _scriptureText;
    private int _listLength;
    private int _userSelection;

    public void GetLibrary ()
    {
         // Stretch Goal
        // Load Scriptures from file
        ScriptureLibrary scriptures = new ScriptureLibrary();
        scriptures.LoadScriptures();
        _referenceList = scriptures.ReturnReference();
        _textList = scriptures.ReturnText();
        _listLength = _referenceList.Count;
    }

    public void SelectScripture (int userSelection = 0)
    {
        // Stretch Goal allows user to select scripture or selects a random scripture
        _userSelection = userSelection;
        
        // If userSelection = 0 generate random int to select scripture


        // Else subtract one from user selection to select scripture

        // Assign scripture to verse and reference variables

    }


    public string ReturnReference ()
    {
        return _scriptureReference;
    }

    public string ReturnText ()
    {
        return _scriptureText;
    }
}