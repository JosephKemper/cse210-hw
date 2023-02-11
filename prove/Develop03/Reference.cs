using System;

public class Reference
{
    // Selects and returns scripture reference for user to memorize
    private string _scriptureReference;
    private string _scriptureText;
    private List<string> _scriptureList = new List<string> ();
    private int _listLength;
    private int _userSelection;

    

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