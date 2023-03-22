using System;

class Video
{
private string _title;
private string _author;
private string _fileName = "RawVideoFile.txt";
protected List <Comment> _comments = new List<Comment>();
private string _rawData;

public void LoadFile ()
{
    //Format URL||VideoTitle||Author/channelName||VideoLength||Name||Comment|||
    //Comments are repeated an unknown number of times. 
    _rawData = File.ReadAllText(_fileName);
    Console.WriteLine(_rawData);
}


public void ProcessComments ()
{
}

public void DisplayVideoData ()
{
}

public void GetTitle ()
{
}

public void SetTitle ()
{
}

public void GetAuthor ()
{
}

public void SetAuthor ()
{
}

public void GetLength ()
{
}

public void SetLength ()
{
}

public Video ()
{
}
}