using System;

class Comment
{
    private string _name;
    private string _comment;
    private string _formattedComment;

    public void DisplayComment (){
        Console.WriteLine (_formattedComment);                
        }
    
    public void FormatComment(string name, string comment){
        // Format comments for ready display to console
        _formattedComment = $"{name} -- {comment}";
        }
    
    public string GetFormattedComment(){
        return _formattedComment;
        }

    public string GetName (){
            return _name;
        }
    
    public void SetName (string name){
            _name = name;
        }

    public string GetComment (){
            return _comment;
        }

    public void SetComment (string comment){
            _comment = comment;
        }
}