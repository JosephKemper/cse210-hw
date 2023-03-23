using System;

class Comment
{
    private string _name;
    private string _comment;

    public void DisplayComment (){
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