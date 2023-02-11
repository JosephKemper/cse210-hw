using System;
namespace Develop03;

// Stretch Goal
// Enabling user choice of options
public class Menu
{
    private List <string> _referenceList = new List<string>();
    private int _listLength;
    private int _optionNumber;
    public void MainMenu ()
    {
        Console.WriteLine ();
        Console.WriteLine ("1. Choose a scripture to memorize");
        Console.WriteLine ("2. Memorize a random scripture");
        Console.WriteLine ("3. Quit");
        Console.WriteLine ();
        Console.Write ("Please enter your selection or type 'quit' to exit: ");
    }

    public void ScriptureSelection()
    {
        ScriptureLibrary referenceMenu = new ScriptureLibrary();
        _referenceList = referenceMenu.ReturnReference();
        _listLength = _referenceList.Count;
        for (int i = 0; i < _listLength; i++){
            _optionNumber = i+1;
            Console.WriteLine ($"{_optionNumber}. {_referenceList[i]}");
        }
    }


}