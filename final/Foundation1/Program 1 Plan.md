Program 1: Plan
Program Purpose
Track YouTube videos and the comments left on them. 
Input
Raw list of values that have arbitrary marks separating them. 
Output
Displays Title, Author, length (in seconds), number of comments, a list of all comments (including name and comment) repeated for each video. 

Notes
Will store Video info in Text file. Will have two different Separators. One (currently thinking |||) will separate the different videos and their respective data from each other, the other (currently thinking ||) will separate the data about each video from the other data about the video. Upon loading the program, it will automatically load a file with the proper name and will split the videos and their data up and then will make a second split and then attach the appropriate video info to its respective variables. 
<code>
Classes
Video
Methods
LoadRawFile (filename) : _rawData List < String >
ProcessComments(_rawData List < String >) :_comments : List< comment >
DisplayVideoData(_rawData List< String >)
GetTitle()
SetTitle(title) : String
GetAuthor()
SetAuthor(author) : String
GetLength()
SetLength(length) : Int
Video(filename)
</code>
<code>
Member Variables
_title : String
_author : String
_length : Int
_comments : List < comment >
_rawData List < String >
</code>
<code>
Comment
Methods
DisplayComment(CommentList List < Comment >)
Comment() //Default constructor used to create list
Comment(CommentList List < Comment >) // Used when trying to display comments
GetName() : String
SetName(name)
GetComment () : String
SetComment ()
</code>
<code>
Member Variables
_name : String
_comment : String
</code>
UML URL //www.plantuml.com/plantuml/png/XP5HQy8m4CVVyoaEVAaJyLraE9IDWOmnjxrAQ4yjfCb8heZ8llikoNMbcsCl3NVvty_BpsKWxQbjZ7glAtHmCvt2oZKDMb8heqE0rB-e2MoShbxqwRus2CMUlrOtE8OvxBm-hJLfsDI1OB4bNzl3BKyyUrTY2C8BnVKW8tQbH62UxXPIHyYw3Xz6dzCQSNX8-OPmyW7fjIQ3HIosNK7n6zVCoPoxQ-del0IxIgVZPtI3za37BYgLIKUCFhAeIPRKIr5JsANVxLdSoVn1AtC4C_fRmmYklbfzAlcNnF6b5oQTGiuu9jwbavnrgJ7CPclSwzOGbCu6ycr9paCRi09oK7hKX60O85F_i9a7Rt7uT4GBvC-yRmHLUJledfebFx6rOc1-AytaCuU43R-2_OMAKdba8BxJslTOsn9jrJRc2m00