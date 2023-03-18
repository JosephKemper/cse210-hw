Program 1: Plan
Program Purpose
Track YouTube videos and the comments left on them. 
Input
Raw list of values that have arbitrary marks separating them. 
Output
Displays Title, Author, length (in seconds), number of comments, a list of all comments (including name and comment) repeated for each video. 

Notes
Will store Video info in Text file. Will have two different Separators. One (currently thinking |||) will separate the different videos and their respective data from each other, the other (currently thinking ||) will separate the data about each video from the other data about the video. Upon loading the program, it will automatically load a file with the proper name and will split the videos and their data up and then will make a second split and then attach the appropriate video info to its respective variables. 

Classes
Video
Methods
LoadRawFile (filename) : _rawData List <String>
ProcessComments(_rawData List <String>)
DisplayVideoData(_rawData List<String>)

Video(filename)


Member Variables
_title : String
_author : String
_length : Int
_comments : List<comment>
_rawData List<String>


Comment
Methods
DisplayComment(CommentList List <Comment>)
Comment() //Default constructor used to create list
Comment(CommentList List <Comment>) // Used when trying to display comments


Member Variables
_name : String
_comment : String

