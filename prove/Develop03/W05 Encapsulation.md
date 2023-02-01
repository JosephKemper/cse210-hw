1. What part of the learning activity was the hardest for you?
Trying to figure out how to properly create a class outline. 

Program Specifications
1. What does the program do?

The program displays a scripture and its reference for the user, and then will slowly remove words from the reference to help the user memorize the text

2. What user inputs does it have?

The enter key and typing quit

3. What output does it produce?

It will display the scripture and its text and will slowly remove words each time the user hits enter.

4. How does the program end?

User types quit

Determine the classes
1. What are good candidates for classes in this program?

Scripture Class, Word Class, Reference Class

2. What are the primary responsibilities of each class?
Scripture Class
Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.

A class is present that encapsulates the responsibilities of a Scripture. Behavior that is specific to Scriptures is all done by this class, not in other places in the program. And, this class does not include items or behaviors that do not pertain to it.

Word Class
Keeps track of a single word and whether it is shown or hidden.

A class is present that encapsulates the responsibilities of a Word (including that the Word class is responsible for storing it's own shown/hidden state). Behavior that is specific to Words is all done by this class, not in other places in the program. And, this class does not include items or behaviors that do not pertain to it.

Reference Class
Keeps track of the book, chapter, and verse information.

A class is present that encapsulates the responsibilities of a Reference (including handling multiple verses). Behavior that is specific to References is all done by this class, not in other places in the program. And, this class does not include items or behaviors that do not pertain to it.

Define class behaviors
1. What are the behaviors this class will have in order to fulfill its responsibilities? (In other words, what things should this class do?)

Scripture - Keeps track of the reference and the text of the scripture. Can hide words and get the rendered display of the text.

Reference - Keeps track of the book, chapter, and verse information.

Word - Keeps track of a single word and whether it is shown or hidden.


Define class attributes
1. What attributes does this class need to fulfill its behaviors? (In other words, what variables should this class store?)

2. What are the data types of these member variables?

3. What constructors should each class have?

Define Constructors
1. What constructors should each class have?
    In other words, what parameters should you pass in when creating an object of that type.

2. What other work needs to be done to set up these objects?
    For example, does the constructor need to run code to perform set up tasks, like creating lists, iterating through variables, etc.

