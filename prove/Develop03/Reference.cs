using System;

public class Reference
{
// Keeps track of the book, chapter, and verse information.
private string _combinedReference = "Doctrine and Covenants 6:34-36";
// Verse count, if 1 then it tells the class to use the single verse constructor, if multiple, then it tells the class to use the multiple verse constructor.

// Book:String 
private string _book;

// Chapter:String
private string _chapter;

// FirstVerse:String
private string _firstVerse;

// LastVerse:String
private string _lastVerse;

// Look up -- Used by Scripture class to pull verse to memorize

// 1 verse constructor
// Combines book name, chapter and verse into the following format Book c:v

// multiple verse constructor
// Combines book name, chapter and verse into the following format Book c:v-v1

    public string ReturnReference ()
    {
        return _combinedReference;
    }
}