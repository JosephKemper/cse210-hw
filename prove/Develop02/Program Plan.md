Program Outline and requirements.
Display menu for user with the following options
1. Write
2. Display
3. Load
4. Save
5. Quit

Write should give prompt to user for what to write journal entry about, and let them write a journal entry about the prompt. 

The prompt should be randomly pulled from a list of possible journal prompts. 

Hitting enter should finish the journal entry. 

Display should display to console all journal entries, in this format 
Date [show the date the journal entry was written] - Prompt: [Display the prompt the user was given for that journal entry]? [Display journal entry text] 

Save will save the journal to a text file, giving the user a chance to name the file. 

Load will let the user choose the file name that they want to load prior data from, and that will pull up all previously saved data. And that will let them continue the journal as previously entered. 

Quit will end the program. The program should continue to loop until quit is selected from the main menu. 


Main menu -- should loop until quit is selected. Should call all other commands as desired. After completion, with the exception of quit, all other commands should take you back to the main menu. 

---Goal----
Design the whole program into classes
-----------


---class mainMenu---
needs to display the menu options
take input from the user
launch the class based on the option the user selects
exit the program when the user desires

---Class WriteJournalEntry---
Get current date from user computer
Call GenerateJournalPrompt for to display Journal Prompt for user
Save journal prompt to variable
Display journal prompt to user
Get input from user from user
Store input in variable
Return each variable


---Class CreateJournalEntry---
Called by WriteJournalEntry to convert journal entry to a list containing [CurrentDate, JournalPrompt, JournalText]
The list will be a string based list so CurrentDate will be converted to string.


---Class CreateUserJournal---
create a list of each JournalEntry list

---Class DisplayJournal---
Iterate through the UserJournal to pull out each JournalEntry, then will assign the elements of the journal to a variable and display them to the screen. 

Optional but ideal
add the option to pause the output to give the user a chance to read the journal entries for longer journals.

---Class LoadJournal---
Let user enter file name
Load the journal from the file
store text in UserJournal List

---Class SaveJournal---
Saves all data to file giving the user option to name file

---JournalPrompts---
Required
Randomly select a journal prompt for the user
Return Journal Prompt

Optional but ideal
Track which entries have been used and create a way to only display prompts that have been used the least number of times. 
Possible implementation
create a second list, containing integers equal in length to number of prompts. Start each integer at 0 and increase it by 1 each time that prompt has been used. And only select prompts based on what has been used the least number of times. 