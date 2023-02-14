Create base Class

Begin by creating a new file and a class for your base Assignment class.
Add the attributes as private member variables.
Create a constructor for this class that receives a student name and topic and sets the member variables.
Add the method for GetSummary() to return the student's name and the topic.
Test your class by returning to the Main method in the Program.cs file. Create a simple assignment, call the method to get the summary, and then display it to the screen.
Sample Output

Samuel Bennett - Multiplication


Create the MathAssignment class

Create a new file for the MathAssignment class.
Create this class and make sure to specify that it inherits from the base Assignment class.
Add the attributes as private member variables. Make sure that you do not create new member variables for the ones you inherited from the base class.
Create a constructor for your class that accepts all four parameters, have it call the base class constructor to set the base class attributes that way.
Add the GetHomeworkList() method.
Test your class by returning to the Main method and creating a new MathAssignment object and set its values. Make sure to test both the GetSummary() and the GetHomeworkList() methods.
Sample Output


Roberto Rodriguez - Fractions
Section 7.3 Problems 8-19

Create the WritingAssignment class

Follow the same pattern as before by creating a new file for the WritingAssignment class.
Create the class and set up the inheritance relationship.
Add the member variables and set up the constructor as you did for the MathAssignment class.
Add the GetWritingInformation() method.
Notice that this method needs to access the _studentName variable defined in the base class. Even though WritingAssignment class inherited this attribute, it is private, so you cannot access it directly in the derived class.

To get the data you need for the method you can either make the variable protected in the base class, or you can create a public GetStudentName method to return it.

Return to Main and test your new class.
Sample Output


Mary Waters - European History
The Causes of World War II by Mary Waters