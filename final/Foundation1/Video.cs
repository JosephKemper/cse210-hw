using System;

class Video{
    private string _title;
    private string _author;
    private int _length;
    private string _fileName = "RawVideoFile.txt";
    protected List <Comment> _comments = new List<Comment>();
    private string _rawData;

    public void LoadFile (){
        //Format URL||VideoTitle||Author/channelName||VideoLength||Name||Comment|||
        //Comments are repeated an unknown number of times. 
        _rawData = File.ReadAllText(_fileName);
        Console.WriteLine(_rawData);
        }


    public void ProcessComments (){
        }

    public void DisplayVideoData (){
        }

    public string GetTitle (){
            return _title;
        }

    public void SetTitle (string title){
            _title = title;
        }

    public string GetAuthor (){
            return _author;
        }

    public void SetAuthor (string author){
            _author = author;
        }

    public int GetLength (){
            return _length;
        }

    public void SetLength (int length){
            _length = length;
        }

    public Video (){
        }

}