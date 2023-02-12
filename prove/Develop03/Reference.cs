using System;
namespace Develop03;

public class Reference
{
    // Selects and returns scripture reference for user to memorize
    private List<string> _referenceList = new List<string>();
    private List <string> _scriptureList = new List<string> ();
    private string _scriptureReference;
    private string _scriptureText;
    private int _listLength;
    private int _userSelection;
    private int _userIndex;
    private Random _randomIndex = new Random();

    
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

    public void SelectScripture (int userSelection = 0)
    {
        // Stretch Goal allows user to select scripture or selects a random scripture
        _userSelection = userSelection;
        
        // If userSelection = 0 generate random int to select scripture
        if (_userSelection == 0){
            _userIndex = _randomIndex.Next(0,_listLength);
        }
        // Else subtract one from user selection to select scripture
        else {
            _userIndex = _userSelection -1;
        }
        _scriptureReference = _referenceList [_userIndex];
        _scriptureText = _scriptureList [_userIndex];
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