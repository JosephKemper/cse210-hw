using System;

class Video{
    private string _title;
    private string _author;
    private int _length;
    private int _hours;
    private int _minutes;
    private int _seconds;
    private int _numberOfComments;
    protected List<string> _unprocessedVideoList = new List<string> ();
    protected List<string> _videoProcessingList = new List<string>();
    protected List<string> _lengthProcessingList = new List<string>();
    private string _fileName = "RawVideoFile.txt";
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
        // Name of person leaving the comment is at index 4
        // Comment is at index 5
        // The next comment/name is found by adding 2 to each index.
        Comment extractComments = new Comment();
        for (int i = 4; i < _videoProcessingList.Count; i+=2){
                extractComments.SetName(_videoProcessingList[i]);
                extractComments.SetComment(_videoProcessingList [i+1]);
                extractComments.FormatComment (extractComments.GetName(),extractComments.GetComment());
                extractComments.GetFormattedComment();
                extractComments.DisplayComment();
            }
            Console.WriteLine();
            Console.WriteLine ("---End of Video Comments---");
            Console.WriteLine ();
        }

    public void DisplayVideoData (){
        Comment showComments = new Comment();
        //Format URL||VideoTitle||Author/channelName||VideoLength||Name||Comment|||
        foreach (string video in _unprocessedVideoList){
            _videoProcessingList.Clear();
            _videoProcessingList = video.Split("||").ToList();
            _numberOfComments = (_videoProcessingList.Count-4)/2;
            _title = _videoProcessingList [1];
            _author = _videoProcessingList [2];
            _length = FindLength (_videoProcessingList[3]);
            Console.WriteLine ($"Title: {_title}");
            Console.WriteLine ($"Author/Channel Name: {_author}");
            Console.WriteLine ($"Length (in seconds): {_length}");
            Console.WriteLine ($"There are {_numberOfComments} Comments");
            Console.WriteLine();
            Console.WriteLine("----Comments----");
            Console.WriteLine();
            ProcessComments();
            }
        }

    public Video (){
        }

}