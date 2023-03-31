using System;

class Program
{

    static void Main(string[] args)
    {
        Console.WriteLine("Program 3: Inheritance with Event Planning");
        /* 
        Program Purpose
        Generate 3 different templates for 3 different kind of events
        Program Inputs
        Event Details in file
        Program Outputs
        3 different messages for each event
        */

        string _eventsFile = "Events.txt";
        List<string> _eventList = new List<string>();

        
        
        

        foreach (string line in File.ReadLines(_eventsFile)){
            _eventList.Add(line);
            }
        foreach (string line in _eventList){
            string [] parts = line.Split("||");
            if (parts[0] == "Lecture"){
            Lecture newLecture = new Lecture(line);
            }
            else if (parts [0] == "Reception"){
            Reception newReception = new Reception(line);
            }
            else if (parts [0] == "Outdoor Gathering"){
            Gathering newGathering = new Gathering(line);
            }
            else {
            Console.WriteLine("There seems to be a problem with the data");
            }
            
            }
    }
}
