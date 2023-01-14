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
Randomly select journal prompt
Save journal prompt to variable
Display journal prompt to user
Get input from user from user
Store input in variable

CreateEntryInstanceName
take in two digit promptIdentifier and CurrentDate
Convert promptIdentifier and CurrentDate to the following format xxddmmmyyy 
return xxddmmmyyy to be used in creating unique JournalEntry instance name.

create JournalEntry instance using CurrentDate, JournalPrompt, and JournalEntry 

------Needed to do --------
Figure out when UserJournal is called

---Class JournalEntry---
Called by WriteJournalEntry to convert journal entry to a list containing [CurrentDate, JournalPrompt, JournalEntry]
naming convention for JournalEntry instances, will be PromptIdentifierDate for example if the user used prompt 7 on 14 Jan 2023 the class instance would be named 714Jan2023

---Class UserJournal---
create a list of each JournalEntry instance


---Class DisplayJournal---

---Class LoadJournal---

---Class SaveJournal---

---JournalPrompts---
Store a collection of journal prompts
Give each journal prompt a unique promptIdentifier number
Return journal prompt and number when called