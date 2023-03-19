Program 3: Inheritance with Event Planning

<Code>
Program Purpose
    Generate 3 different templates for 3 different kind of events
Program Inputs
    Event Details in file
Program Outputs
    3 different messages for each event
Classes
    Event, Lecture, Reception, Gathering, and Address
</Code>

Classes
<Code>
Event
    Purpose
        Process and store all details shared by each event type
    Inputs
        File containing details for 3 different kinds of events.
    Outputs
        Any shared program details
    Methods
        LoadEvents(string fileName) 
        ProcessEvent(eventDetailsString)
        DisplayStandardDetails ()
        DisplayShortDescription ()
        DisplayFullDetails ()
        Event (_fileName)
        GetTitle()
        SetTitle(string : title)
        GetDescription()
        SetDescription(string: description)
        GetDate()
        SetDate(String: Date)
        GetTime()
        SetTime(string : Time)
        GetAddress()
        SetAddress(Address : address)
    MemberVariables
        _title : String
        _description : String
        _date_ : String
        _time : String
        _address : Address
        _eventList : List < String>
</Code>

<Code>
Lecture : Event
    Purpose
        Generate messages for Lectures
    Inputs
        Strings containing lecture event details
    Outputs
        3 different messages for each lecture.
    Methods
        LoadLectureEvent (_eventList: List)
        DisplayFullDetails ()
        Lecture (string: fileName)
    MemberVariables
        _speaker
        _capacity
</Code>

<Code>
Reception : Event
    Purpose
        Generate messages for Receptions
    Inputs
        Strings containing reception event details
    Outputs
        3 different messages for each reception
    Methods
        LoadReceptionEvent(_eventList: List)
        DisplayFullDetails ()
        Reception (string : fileName)
    MemberVariables
        _Email : String

</Code>

<Code>
Gathering : Event
    Purpose
        Strings containing Gathering event details
    Inputs
        Strings containing Gathering event details
    Outputs
        3 different messages for each 
    Methods
        LoadGatheringEvent (_eventList: List)
        DisplayFullDetails ()
        Gathering (string : fileName)
    MemberVariables
        _forecast : string
</Code>

<Code>
Address
    Purpose
        Format addresses for events
    Inputs
        Strings containing event addresses
    Outputs
        Properly formatted event address
    Methods
        LoadAddress(_eventList: List)
        DisplayAddress ()
    MemberVariables
        _streetAddress : String
        _city : String
        _state : String
        _zip : String
</Code>

UML URL
//www.plantuml.com/plantuml/dpng/dPFBQkim48RtVWh1sJZdu1S8uP3IfDc4KkhkpM1F6b7vWZGkf9TthoHBOslHGBk9DVzSvcDciZK4ciPMPVjNx4XiFegY44UiQTIOQ8zOuq2oxnBr07H6BRldeFvruatJQ3GcosuL62Eyvptx9uuzDDumUNMI2k-XnPMmZWVTrpR1-t9qlpiaaCgKv6glRCXEca71fIJe6j1Dy8jywJltsYQQMaiFcZZlHgMIf8bt1d7Q0Ub9aa8VK4R3U0Yn5cJD6BVe4wCNKiXPYsRMOY8Gr_VlCeGwWo7Q1KExGB1M30fJ3d5iXg-DXUcroWfHUNIhJSsSiY1BTI2i4eLacwO2juYR_YFyrexIa5NzPnCI_cUVyH32MObu2y6Ec-0IKuKho-DAF6VUekCp0y8BQlUiOO1QqcM6u3jc35Oyo8yuvcAyeXHbtzhWUNXCmVyRfc3b5-FWtEymJht66lnoJ4eILyWSmRxMFwRaqxH98vzVSYTky8bW20WNIlKcXsGuM-oQiLLV