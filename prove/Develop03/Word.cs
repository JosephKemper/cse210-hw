using System;

public class Word
{
// Used to render the text of a hidden word
    private string _hiddenWord;
    private string _visibleWord;
    private int _wordLen;
    private int _letterCount;
    

    public string RenderHiddenWord (string visibleWord)
    {
        _hiddenWord = "";
        _visibleWord = visibleWord;
        _wordLen = _visibleWord.Length;
        // for loop syntax taken from https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/iteration-statements
        for (_letterCount = 0; _letterCount < _wordLen; _letterCount++){
            _hiddenWord += "_";
            }
        return _hiddenWord;

    }

}