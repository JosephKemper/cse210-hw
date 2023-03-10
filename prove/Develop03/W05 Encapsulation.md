Step 3: Discuss the Preparation Learning Activity
1. What part of the learning activity was the hardest for you?
Trying to figure out how to properly create a class outline. 

Step 4: Program Specifications
1. What does the program do?

The program displays a scripture and its reference for the user, and then will slowly remove words from the reference to help the user memorize the text

2. What user inputs does it have?

The enter key and typing "quit"

3. What output does it produce?

It will display the scripture and its text and will slowly remove words each time the user hits enter.

4. How does the program end?

User types quit or gets to where all words of a scripture are replaced with underscores and hits enter one more time

Step 5: Determine the classes
1. What are good candidates for classes in this program?

Scripture Class, Word Class, Reference Class

2. What are the primary responsibilities of each class?

Scripture Class
Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.


Word Class
Keeps track of a single word and whether it is shown or hidden.

Reference Class
Keeps track of the book, chapter, and verse information.


Step 6: Define class behaviors
1. What are the behaviors this class will have in order to fulfill its responsibilities? (In other words, what things should this class do?)

Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.

    Hide Words -- uses the hide function in the word class to hide each word as needed. 
    Get Rendered Text -- assembles the modified verse for display to user
    Set Rendered Text -- Displays rendered text to user
    Is Completely Hidden -- checks if the verse is completely hidden and exits the program after another input from user


Word - Keeps track of a single word and whether it is shown or hidden.
    Hide -- hides a single word
    Show -- shows a single word
    Is Hidden -- attaches a status of hidden to each word
    Get Rendered Text -- converts a single word into underscores to then be hidden by program

Reference - Keeps track of the book, chapter, and verse information.
    Look up -- Used by Scripture class to pull verse to memorize


Step 7: Define class attributes
1. What attributes does this class need to fulfill its behaviors? (In other words, what variables should this class store?)

Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
    Reference : String
    Verse : String
    VisibleVerseList:List <String> 

Word - Keeps track of a single word and whether it is shown or hidden.
    VisibleWord:String
    HiddenWord:String

Reference - Keeps track of the book, chapter, and verse information.
    Book:String 
    Chapter:String
    FirstVerse:String
    LastVerse:String

2. What are the data types of these member variables?

Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.
    Reference : String
    Verse : String
    VisibleVerseList:List <String> 

Word - Keeps track of a single word and whether it is shown or hidden.
    VisibleWord:String
    HiddenWord:String

Reference - Keeps track of the book, chapter, and verse information.
    Book:String 
    Chapter:String
    FirstVerse:String
    LastVerse:String

3. What constructors should each class have?

Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.

    hide words -- decides which words in the verse will be hid and replaces them in the word list
    combine scripture -- combines the reference, and text of the scripture to one string
    display text -- display's the scripture text to the user. 


Word - Keeps track of a single word and whether it is shown or hidden.

    Convert word 
    converts word to list
    constructs a series of underscores equal to the length of the word list


Reference - Keeps track of the book, chapter, and verse information.

    1 verse constructor
    Combines book name, chapter and verse into the following format Book c:v

    multiple verse constructor
    Combines book name, chapter and verse into the following format Book c:v-v1

Step 8: Define Constructors
1. What constructors should each class have?
    In other words, what parameters should you pass in when creating an object of that type.

Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.


Word - Keeps track of a single word and whether it is shown or hidden.
    Optional parameter of shown/hidden default shown

Reference - Keeps track of the book, chapter, and verse information.

    Verse count, if 1 then it tells the class to use the single verse constructor, if multiple, then it tells the class to use the multiple verse constructor. 

2. What other work needs to be done to set up these objects?
    For example, does the constructor need to run code to perform set up tasks, like creating lists, iterating through variables, etc.

    The word list that will store the verse text, will need to be regularly updated with underscores as each word slowly gets replaced by underscores, and then recombined back into a string and then combined back with the reference to be shown to the user. 