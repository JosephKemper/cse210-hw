using System;

class Video{
    private string _title;
    private string _author;
    private int _length;
    private int _hours;
    private int _minutes;
    private int _seconds;
    private List<string> _unprocessedVideoList = new List<string> ();
    private List<string> _videoProcessingList = new List<string>();
    private List<string> _lengthProcessingList = new List<string>();
    private string _fileName = "RawVideoFile.txt";
    protected List <Comment> _comments = new List<Comment>();
    private string _rawData;

    public void LoadFile (){
        //Format URL||VideoTitle||Author/channelName||VideoLength||Name||Comment|||
        //Comments are repeated an unknown number of times. 
        _rawData = File.ReadAllText(_fileName);
        //Console.WriteLine(_rawData);
        _unprocessedVideoList = _rawData.Split("|||").ToList();
        }

    public int FindLength (string rawLength){
        _lengthProcessingList = rawLength.Split(":").ToList();
        if (_lengthProcessingList.Count == 2){
                _minutes = int.Parse(_lengthProcessingList[0]);
                _seconds = int.Parse(_lengthProcessingList[1]);
                _length = (_minutes *60)+ _seconds;
            }
        else{
            _hours = int.Parse(_lengthProcessingList[0]);
            _minutes = int.Parse(_lengthProcessingList[1]);
            _seconds = int.Parse(_lengthProcessingList[2]);
            _length = (_hours*60*60)+(_minutes *60)+ _seconds;
            }
        return _length;
        }

    public void ProcessComments (){
        }
// TODO #18 Bug DisplayVideoData printing multiple copies of each video in the list
    public void DisplayVideoData (){
        //Format URL||VideoTitle||Author/channelName||VideoLength||Name||Comment|||
        foreach (string video in _unprocessedVideoList){
            _videoProcessingList.Clear();
            _videoProcessingList = video.Split("||").ToList();
            //Console.WriteLine(item);
            _title = _videoProcessingList [1];
            _author = _videoProcessingList [2];
            _length = FindLength (_videoProcessingList[3]);
            Console.WriteLine ($"Title: {_title}");
            Console.WriteLine ($"Author/Channel Name: {_author}");
            Console.WriteLine ($"Length (in seconds): {_length}");
            Console.WriteLine ();
            }
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