using System;
/*
Word Class
Purpose: 
Tracks and decides whether a word in a given scripture is shown or hidden. 
Inputs: 
A word and its index
Outputs: 
Either the word or a series of underscores back. 
Implementation idea
Use dictionary that has the index of each word as the look up variable 
and either shown or hidden as the return variable
*/

public class Word
{
    private List <int> _unhiddenWords = new List<int>();
    private List <string> _wordList = new List<string>();


    public void PrepWords(string scripture)
    {
        _wordList = scripture.Split().ToList();
    }

    public string ReturnWords ()
    {
        return string.Join(" ",_wordList);
    }
}